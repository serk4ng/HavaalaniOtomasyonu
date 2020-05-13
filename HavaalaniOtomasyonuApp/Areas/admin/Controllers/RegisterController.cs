using HavaalaniOtomasyonuApp.DAL;
using HavaalaniOtomasyonuApp.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HavaalaniOtomasyonuApp.Areas.admin.Controllers
{
    public class RegisterController : Controller
    {
        // GET: admin/Register
        public ActionResult CreateAdmin()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult CreateAdmin(CreateadminModel model)
        //{
        //    return View();
        //}


    }
}
