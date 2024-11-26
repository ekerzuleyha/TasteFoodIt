using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class AdminLayoutController : Controller
    {
        TasteContext context = new TasteContext();

        public ActionResult Index()
        {
            return View();
        }


        //layoutun partialhead i. dinamik bir yapı olduğu için controllar içine oluşturduk.
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            ViewBag.notificationIsReadByFalseCount = context.Notifications.Where(x => x.IsRead == false).Count();
            //admin panelinde hepsi listelenecek ama bildirimlerde sadece okunmayanlar olacak.
            var values = context.Notifications.Where(x => x.IsRead == false).ToList();
            ViewBag.m = values.Count();
            ViewBag.isim = Session["b"];
            ViewBag.resim = Session["c"];
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

        public ActionResult NotificationStatusChangeToTrue(int id)
        {
            var value = context.Notifications.Find(id);
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("CategoryList", "Category");

        }

        public ActionResult MessageStatusChangeToTrue(int id)
        {
            var values = context.Contacts.Find(id);
            values.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("ContactList", "Contact");
        }


        public PartialViewResult PartialNavbarMessage()
        {
            var values = context.Contacts.Where(x => x.IsRead == false).ToList();
            ViewBag.sayı = values.Count();
            return PartialView(values);
        }
    }
}