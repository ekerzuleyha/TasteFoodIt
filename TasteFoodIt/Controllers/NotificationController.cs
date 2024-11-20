using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entities;

namespace TasteFoodIt.Controllers
{
    public class NotificationController : Controller
    {
        TasteContext context = new TasteContext();


        public ActionResult NotificationList()
        {
            var values = context.Notifications.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateNotification()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateNotification(Notification n)
        {
            n.Date = DateTime.Today;
            n.IsRead = false;
            context.Notifications.Add(n);
            context.SaveChanges();
            return RedirectToAction("NotificationList");
        }


        public ActionResult NotificationIsReadChangeToTrue(int id)
        {
            var values = context.Notifications.Find(id);
            values.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("NotificationList");
        }

        public ActionResult NotificationIsReadChangeToFalse(int id)
        {
            var values = context.Notifications.Find(id);
            values.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("NotificationList");
        }

        public ActionResult DeleteNotification(int id)
        {
            var values = context.Notifications.Find(id);
            context.Notifications.Remove(values);
            context.SaveChanges();
            return RedirectToAction("NotificationList");
        }

        [HttpGet]
        public ActionResult UpdateNotification(int id)
        {
            var value = context.Notifications.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateNotification(Notification n)
        {
            var value = context.Notifications.Find(n.NotificationId);
            value.Description = n.Description;
            value.NotificationIcon = n.NotificationIcon;
            value.IconCircleColor = n.IconCircleColor;
            value.Date = DateTime.Now;
            context.SaveChanges();
            return RedirectToAction("NotificationList");
        }
    }
}