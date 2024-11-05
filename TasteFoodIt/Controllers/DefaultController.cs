using System.Linq;
using System.Web.Mvc;
using TasteFoodIt.Context;

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
            var values = context.Sliders.ToList();
            return PartialView(values);
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
            var values = context.Chefs.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSecret()
        {
            return PartialView();
        }

        public PartialViewResult PartialBilgi()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {

            return PartialView();
        }

        public PartialViewResult PartialSocialMedia()
        {
            var values = context.SocialMedias.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialOpenDayHour()
        {
            var values = context.OpenDayHours.ToList();
            return PartialView(values);
        }

        public ActionResult NavbarAbout()
        {
            return View();
        }

        public PartialViewResult PartialStatistic()
        {
            ViewBag.categoryCount = context.Categories.Count();
            ViewBag.productCount = context.Products.Count();
            ViewBag.chefCount = context.Chefs.Count();
            ViewBag.testimonialCount = context.Testimonials.Count();
            return PartialView();
        }

        public ActionResult NavbarChef()
        {
            return View();
        }

        public ActionResult NavbarMenu()
        {
            return View();
        }

        public ActionResult NavbarReservation()
        {
            return View();
        }

        public ActionResult NavbarContact()
        {
            return View();
        }

        public PartialViewResult PartialContactInformation()
        {
            var values = context.contactInformations.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialContactUs()
        {
            var values = context.Contacts.ToList();
            return PartialView(values);
        }

    }
}