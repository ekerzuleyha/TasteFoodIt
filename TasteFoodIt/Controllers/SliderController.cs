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

        [HttpGet]
        public ActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSlider(Slider s)
        {
            context.Sliders.Add(s);
            context.SaveChanges();
            return RedirectToAction("SliderList");
        }

        public ActionResult DeleteSlider(int id)
        {
            var value = context.Sliders.Find(id);
            context.Sliders.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SliderList");
        }

        [HttpGet]
        public ActionResult UpdateSlider(int id)
        {
            var value = context.Sliders.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSlider(Slider s)
        {
            var value = context.Sliders.Find(s.SliderId);
            value.Title=s.Title;
            value.ImageUrl = s.ImageUrl; ;
            value.Description = s.Description;
            context.SaveChanges();
            return RedirectToAction("SliderList");
        }
    }
}