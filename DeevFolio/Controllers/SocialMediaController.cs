using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeevFolio.Models; 

namespace DeevFolio.Controllers
{
    public class SocialMediaController : Controller
    {
        DevFolioDbEntities db = new DevFolioDbEntities();
        public ActionResult Index()
        {
            var values = db.TblSocialMedia.ToList();
            return View(values);
        }
    }
}