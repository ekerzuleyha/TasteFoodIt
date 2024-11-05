using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entities;



namespace TasteFoodIt.Controllers
{
    public class SliderController : Controller
    {
        TasteContext context = new TasteContext();
       
        public ActionResult SliderList()
        {
            var value = context.Sliders.ToList();
            ViewBag.slidercount = context.Sliders.Count();
            return View(value);
        }
    }
}