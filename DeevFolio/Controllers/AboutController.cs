using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeevFolio.Models;
namespace DeevFolio.Controllers
{
    public class AboutController : Controller
    {
        DevFolioDbEntities db = new DevFolioDbEntities();
        public ActionResult Index()
        {
            var values = db.TblAbout.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAbout(TblAbout p)
        {
            db.TblAbout.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAbout(int id)
        {
            var value = db.TblAbout.Find(id);
            db.TblAbout.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = db.TblAbout.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAbout(TblAbout p)
        {
            var value = db.TblAbout.Find(p.AboutID);
            value.AboutID = p.AboutID;
            value.Description = p.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        }
}