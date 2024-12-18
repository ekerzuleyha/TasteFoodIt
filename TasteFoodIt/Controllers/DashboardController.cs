﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entities;

namespace TasteFoodIt.Controllers
{
    public class DashboardController : Controller
    {
        TasteContext contect = new TasteContext();

        public ActionResult Index()
        {
            ViewBag.v1 = contect.Categories.Count();
            ViewBag.v2 = contect.Products.Count();
            ViewBag.v3 = contect.Chefs.Count();
            ViewBag.v4 = contect.Reservations.Where(x => x.ReservationStatus == "Aktif").Count();
            return View();
        }
    }
}