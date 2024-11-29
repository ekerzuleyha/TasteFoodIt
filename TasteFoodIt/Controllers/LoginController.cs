using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Entities;
using TasteFoodIt.Context;
using System.Web.Security;

namespace TasteFoodIt.Controllers
{

    public class LoginController : Controller
    {
        TasteContext context = new TasteContext();

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Index(Admin p)
        {

            var values = context.Admins.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);
            if (values != null )
            {
                //çerez değeri oluşturup kullanıcının bilgilerini tutucaz. bizden kullanıcı adı istiyor ,bizde diyoruz ki values dan gelen kullanıcı adı kullanıcı adı olarak atansın,true diyerek bilgilerin kalıcı olarak kaydedilmesini
                FormsAuthentication.SetAuthCookie(values.Username, true);
                Session["a"] = values.Username;
                Session["b"] = values.NameSurname;
                Session["c"] = values.ImageUrl;
                Session["d"] = values.Password;
                //return RedirectToAction("ProductList","Product");
                return RedirectToAction("Index","Profile");
            }

            return View();
        }


        public ActionResult Logut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}