using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Entities;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class AdminController : Controller
    {
        TasteContext context = new TasteContext();

        public ActionResult AdminList()
        {
            var values = context.Admins.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAdmin(Admin a)
        {
            context.Admins.Add(a);
            context.SaveChanges();
            return RedirectToAction("AdminList");
        }

        public ActionResult DeleteAdmin(int id)
        {
            var value = context.Admins.Find(id);
            context.Admins.Remove(value);
            context.SaveChanges();
            return RedirectToAction("AdminList");
        }

        [HttpGet]
        public ActionResult UpdateAdmin(int id)
        {
            var value = context.Admins.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAdmin(Admin a)
        {
            var value = context.Admins.Find(a.AdminId);
            value.NameSurname = a.NameSurname;
            value.Username = a.Username;
            value.Password = a.Password;
            context.SaveChanges();
            return RedirectToAction("AdminList");
        }
    }
}