using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeevFolio.Models;
namespace DeevFolio.Controllers
{
    public class ProfileController : Controller
    {
        DevFolioDbEntities db = new DevFolioDbEntities();
        public ActionResult Index()
        {
            var values = db.TblProfile.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProfile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProfile(TblProfile p)
        {
            db.TblProfile.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProfile(int id)
        {
            var value = db.TblProfile.Find(id);
            db.TblProfile.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProfile(int id)
        {
            var value = db.TblProfile.Find(id);
            return View(value);

        }
        [HttpPost]
        public ActionResult UpdateProfile(TblProfile p)
        {
            var value = db.TblProfile.Find(p.ProfileID);
            value.ProfileID = p.ProfileID;
            value.Phone = p.Phone;
            value.NameSurname = p.NameSurname;
            value.Email = p.Email;
            value.Title = p.Title;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}