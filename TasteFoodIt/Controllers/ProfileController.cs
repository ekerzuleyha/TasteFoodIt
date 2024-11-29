using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TasteFoodIt.Controllers
{
    public class ProfileController : Controller
    {
    //sisteme giriş yapan kişinin bilgilerini tutuyoruz.a dan gelen değeri bu sayfaya taşı
        public ActionResult Index()
        {
            ViewBag.v = Session["a"];
            ViewBag.c = Session["b"];
            ViewBag.x = Session["c"];
            ViewBag.p = Session["d"];
            return View();
        }
    }
}