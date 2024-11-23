using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entities;

namespace TasteFoodIt.Controllers
{
    public class ContactController : Controller
    {
        TasteContext context = new TasteContext();

        public ActionResult ContactList()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }

        [HttpPost]
        public ActionResult SendMessage(Contact c)
        {
            context.Contacts.Add(c);
            c.SendDate = DateTime.Now;
            c.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("NavbarContact", "Default");
        }

        [HttpGet]
        public ActionResult ReadMessage(int id)
        {
            var value = context.Contacts.Find(id);
            value.IsRead = true;
            context.SaveChanges();
            return View(value);
        }

        public ActionResult DeleteMessage(int id)
        {
            var value = context.Contacts.Find(id);
            context.Contacts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }



    }
}