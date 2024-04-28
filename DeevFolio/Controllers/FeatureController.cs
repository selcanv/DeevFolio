using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeevFolio.Models;
namespace DeevFolio.Controllers
{
    public class FeatureController : Controller
    {
        DevFolioDbEntities db = new DevFolioDbEntities();
        public ActionResult Index()
        {
            var values = db.TblFeature.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateFeature(TblFeature p)
        {
            db.TblFeature.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteFeature(int id)
        {
            var value = db.TblFeature.Find(id);
            db.TblFeature.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {
            var value = db.TblFeature.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateFeature(TblFeature p)
        {
            var value = db.TblFeature.Find(p.FeatureID);
            value.FeatureID = p.FeatureID;
            value.HeaderDescription = p.HeaderDescription;
            value.HeaderTitle = p.HeaderTitle;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}