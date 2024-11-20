using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Entities;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class OpenDayHourController : Controller
    {
        TasteContext context = new TasteContext();
        
        public ActionResult OpenDayHourList()
        {
            var values = context.OpenDayHours.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateOpenDayHour()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateOpenDayHour(OpenDayHour o)
        {
            context.OpenDayHours.Add(o);
            context.SaveChanges();
            return RedirectToAction("OpenDayHourList");
        }

        public ActionResult DeleteOpenDayHour(int id)
        {
            var value=context.OpenDayHours.Find(id);
            context.OpenDayHours.Remove(value);
            context.SaveChanges();
            return RedirectToAction("OpenDayHourList");
        }

        [HttpGet]
        public ActionResult UpdateOpenDayHour(int id)
        {
            var value = context.OpenDayHours.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateOpenDayHour(OpenDayHour o)
        {
            var value= context.OpenDayHours.Find(o.OpenDayHourId);
            value.DayName = o.DayName;
            value.OpenHourRange = o.OpenHourRange;
            context.SaveChanges();
            return RedirectToAction("OpenDayHourList");
        }


    }
}