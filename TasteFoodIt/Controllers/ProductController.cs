using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entities;

namespace TasteFoodIt.Controllers
{
    public class ProductController : Controller
    {
        TasteContext context = new TasteContext();

        public ActionResult ProductList()
        {
            var values = context.Products.ToList();
            return View(values);
        }
    }
}