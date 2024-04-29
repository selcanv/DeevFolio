using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeevFolio.Models;
namespace DeevFolio.Controllers
{
    public class ContactController : Controller
    {
        DevFolioDbEntities db = new DevFolioDbEntities();
        public ActionResult Index()
        {
            var values = db.TblContact.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult ReadContact(int id)
        {
            var value = db.TblContact.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult ReadContact()
        {
          
            return RedirectToAction("Index");

        }
        public ActionResult DeleteContact(int id)
        {
            var value = db.TblContact.Find(id);
            db.TblContact.Remove(value);
            return RedirectToAction("Index");
        }
        public ActionResult SendMessage()
        {
            return View();
        }
        public ActionResult MessageList()
        {
            return View();
        }
    }
}