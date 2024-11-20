using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Entities;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class SocialMediaController : Controller
    {
        TasteContext context = new TasteContext();

        public ActionResult SocialMediaList()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateSocialMedia()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateSocialMedia(SocialMedia s)
        {
            s.Status = false;
            context.SocialMedias.Add(s);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            var values = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(values);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var value = context.SocialMedias.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSocialMedia(SocialMedia s)
        {
            var value = context.SocialMedias.Find(s.SocialMediaId);
            value.PlatformName=s.PlatformName;
            value.RedirectUrl = s.RedirectUrl; ;
            value.IcanUrl = s.IcanUrl; ;
            value.Status=s.Status;
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
    }
}