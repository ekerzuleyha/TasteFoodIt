using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Entities;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class ContactInformationController : Controller
    {
        TasteContext context = new TasteContext();

        public ActionResult ContactInformationList()
        {
            ViewBag.adres = context.contactInformations.Select(x=>x.Address).FirstOrDefault();
            ViewBag.email = context.contactInformations.Select(x => x.Email).FirstOrDefault();
            ViewBag.telefon = context.contactInformations.Select(x => x.Phone).FirstOrDefault();
            ViewBag.website = context.contactInformations.Select(x => x.WebsiteUrl).FirstOrDefault();
            ViewBag.contactid = context.contactInformations.Select(x => x.ContactInformationId).FirstOrDefault();
            ViewBag.count = context.contactInformations.Count();
            return View();
        }

        [HttpGet]
        public ActionResult CreateContactInformation()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateContactInformation(ContactInformation c)
        {
            context.contactInformations.Add(c);
            context.SaveChanges();
            return RedirectToAction("ContactInformationList");
        }

        public ActionResult DeleteContactInformation(int id)
        {
            var values = context.contactInformations.Find(id);
            context.contactInformations.Remove(values);
            context.SaveChanges();
            return RedirectToAction("ContactInformationList");
        }

        [HttpGet]
        public ActionResult UpdateContactInformation(int id)
        {
            var value = context.contactInformations.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateContactInformation(ContactInformation c)
        {
            var value = context.contactInformations.Find(c.ContactInformationId);
            value.Address = c.Address;
            value.Email = c.Email; 
            value.Phone = c.Phone;
            value.WebsiteUrl=c.WebsiteUrl;
            context.SaveChanges();
            return RedirectToAction("ContactInformationList");
        }
    }
}