using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Entities;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class ChefController : Controller
    {
        TasteContext context = new TasteContext();

        public ActionResult ChefList()
        {
            var values = context.Chefs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateChef()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateChef(Chef c)
        {
            context.Chefs.Add(c);
            context.SaveChanges();
            return RedirectToAction("ChefList");
        }

        public ActionResult DeleteChef(int id)
        {
            var value = context.Chefs.Find(id);
            context.Chefs.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ChefList");
        }

        [HttpGet]
        public ActionResult UpdateChef(int id)
        {
            var value = context.Chefs.Find(id);
           
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateChef(Chef c)
        {
            var value = context.Chefs.Find(c.ChefId);
            value.NameSurname = c.NameSurname;
            value.Title = c.Title;
            value.Description = c.Description;
            value.ImageUrl = c.ImageUrl;
            context.SaveChanges();

            return RedirectToAction("ChefList");
        }


    }
}