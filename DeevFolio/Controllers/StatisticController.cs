using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeevFolio.Models;

namespace DeevFolio.Controllers
{
    public class StatisticController : Controller
    {
        DevFolioDbEntities db = new DevFolioDbEntities();
        public ActionResult Index()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.skillCount = db.TblSkill.Count();
            //ortalama yetenek puanı
            ViewBag.skillAvgValue = db.TblSkill.Average(x => x.SkillValue);
            //eklenen son başlığın adını getirelim
            //proc oluşturdum
            //modelime dahil ettim 
            ViewBag.lastSkillTitleName = db.GetLastSkillTitle().FirstOrDefault();
            //FirstOrDefault()=> ilk sıradakini alır 

            //1numaralı kategoriye ait proje(Asp.net core) 
            ViewBag.coreCategoryProjectCount = db.TblProject.Where(x => x.ProjectCategory == 1).Count();
            //******************************************************************************************
            ViewBag.serviceCount = db.TblService.Count();
            ViewBag.socialMediaCount = db.TblSocialMedia.Count();
            ViewBag.activeSocialMedia = db.sp_ActiveSocialMedia().FirstOrDefault();
            ViewBag.lastService = db.sp_LastService().FirstOrDefault();
            return View();
        }
    }
}