using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeevFolio.Models;

namespace DeevFolio.Controllers
{
    public class DefaultController : Controller
    {
        DevFolioDbEntities db = new DevFolioDbEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            var values = db.TblFeature.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialProfile()
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialServices()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialStatistic()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.skillCount = db.TblSkill.Count();
            ViewBag.testimonialCount = db.TblTestimonial.Count();
            //ortalama yetenek puanı
            //ViewBag.skillAvgValue = db.TblSkill.Average(x => x.SkillValue);
            ////eklenen son başlığın adını getirelim
            ////proc oluşturdum
            ////modelime dahil ettim 
            //ViewBag.lastSkillTitleName = db.GetLastSkillTitle().FirstOrDefault();
            ////FirstOrDefault()=> ilk sıradakini alır 

            ////1numaralı kategoriye ait proje(Asp.net core) 
            //ViewBag.coreCategoryProjectCount = db.TblProject.Where(x => x.ProjectCategory == 1).Count();
            return PartialView();
        }
        public PartialViewResult PartialProject()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialContact()
        {
            var values = db.TblContact.ToList();
            return PartialView(values);

        }
        public PartialViewResult PartialAddress()
        {
            var values = db.TblAddress.ToList();
            return PartialView(values);

        }
        public PartialViewResult PartialSocialMedia()
        {
            var values = db.TblSocialMedia.ToList();
            return PartialView(values);

        }
        public PartialViewResult PartialTestimonial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);

        }

        public PartialViewResult PartialFooter()
        {

            return PartialView();

        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }



    }
}