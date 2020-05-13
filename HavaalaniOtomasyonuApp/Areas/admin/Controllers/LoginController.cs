using HavaalaniOtomasyonuApp.Areas.admin.Models;
using HavaalaniOtomasyonuApp.Controllers;
using HavaalaniOtomasyonuApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HavaalaniOtomasyonuApp.Areas.admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: admin/Login7
        public static bool check = false;
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            //if (String.IsNullOrEmpty(HttpContext.User.Identity.Name))
            //{
            //    FormsAuthentication.SignOut();
            //    return Redirect("/admin");
            //}
            return Redirect("/home/Index");

            //return View();

        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {

            //if (model.username == null || model.password == null)
            //{
            //    return Redirect("/admin");
            //}

            if (ModelState.IsValid)
            {
                HavaalaniContext db = new HavaalaniContext();
                var kullanici = db.Adminler.Where(a => a.username == a.username && a.password == model.password);

                if (kullanici.Count()>0)
                {               
                    check = true;
                    FormsAuthentication.SetAuthCookie(model.username, true);
                    return RedirectToAction("Login","Login");
                   
                }
                //else
                //{
                //    //ModelState.AddModelError("", "hatalı!");
                //    //return View(model);
                //    return Redirect("/admin");
                //}
            }
            return RedirectPermanent("Login");
        }

        public ActionResult Logout()
        {
            check = false;
            return Redirect("/admin");
        }



    }
}