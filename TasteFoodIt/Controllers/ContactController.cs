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

        //[HttpPost]
        //public ActionResult SendMessage(Contact c)
        //{
        //    context.Contacts.Add(c);
        //    c.SendDate=DateTime.Now;
        //    c. = false;
        //    db.SaveChanges();
        //    return RedirectToAction("Index", "Default");
        //}
    }
}