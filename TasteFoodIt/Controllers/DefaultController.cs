using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entities;

namespace TasteFoodIt.Controllers
{
    public class DefaultController : Controller
    {
        TasteContext context = new TasteContext();

        public ActionResult Index()
        {
            return View();
        }
       
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbarInfo()
        {
            //liste formatıyla tasıma yerine viewbaglerla veri taşıma işlemi yapıcaz.

            ViewBag.phone = context.Addresses.Select(x => x.Phone).FirstOrDefault();
            ViewBag.email = context.Addresses.Select(y => y.Email).FirstOrDefault();
            ViewBag.description = context.Addresses.Select(z => z.Description).FirstOrDefault();

            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialSlider()
        {
            return PartialView();
        }

        public PartialViewResult PartialAbout()
        {
            ViewBag.description = context.Abouts.Select(x => x.Description).FirstOrDefault();
            ViewBag.title = context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.image = context.Abouts.Select(x => x.ImageUrl).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialMenu()
        {
            var values = context.Products.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTestimonial()
        {
            return PartialView();
        }

        public PartialViewResult PartialChef()
        {
            return PartialView();
        }

        public PartialViewResult PartialSecret()
        {
            return PartialView();
        }

       
    }
}