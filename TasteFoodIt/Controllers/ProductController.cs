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


        [Authorize]
        //nu attributun bulunduğu yerde eğer kullanıcı sisteme otantike(adminin giriş yapması) değilse bu listeyi göremez.
        //yetki vermek için kullanlır. product listesine ulaşmak için sadece admin giriş yapsın.//
        public ActionResult ProductList()
        {
            var values = context.Products.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateProduct()
        {
            List<SelectListItem> values = (from x in context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }
                                          ).ToList();
            values.Add(new SelectListItem
            {
                Text="Kategori Seçiniz...",
                Value="0", Selected=true
            });

            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(Product p)
        {
            p.IsActive = true;
            context.Products.Add(p);
            context.SaveChanges();
            return RedirectToAction("ProductList");

        }

        public ActionResult DeleteProduct(int id)
        {
            var value = context.Products.Find(id);
            context.Products.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            var value = context.Products.Find(id);

            List<SelectListItem> categories = (from x in context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.v = categories;
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product p)
        {
            var value = context.Products.Find(p.ProductId);
            value.ProductName = p.ProductName;
            value.Price = p.Price;
            value.CategoryId = p.CategoryId;
            value.Description = p.Description;
            value.IsActive = true;
            value.ImageUrl = p.ImageUrl;
            context.SaveChanges();
            return RedirectToAction("ProductList");

        }


    }
}