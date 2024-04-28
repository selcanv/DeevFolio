using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeevFolio.Models;

namespace DeevFolio.Controllers
{
    public class AddressController : Controller
    {
        DevFolioDbEntities db = new DevFolioDbEntities();
        public ActionResult Index()
        {
            var values = db.TblAddress.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateAddress()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAddress(TblAddress p)
        {
            db.TblAddress.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAddress(int id)
        {
            var value = db.TblAddress.Find(id);
            db.TblAddress.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateAddress(int id)
        {
            var value = db.TblAddress.Find(id);
            return View(value);

        }
        [HttpPost]
        public ActionResult UpdateAddress(TblAddress p)
        {
            var value = db.TblAddress.Find(p.AddressID);
            value.AddressID = p.AddressID;
            value.Description = p.Description;
            value.Email = p.Email;
            value.PhoneNumber = p.PhoneNumber;
            value.Location = p.Location;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}