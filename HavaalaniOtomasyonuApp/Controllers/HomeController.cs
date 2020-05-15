﻿using HavaalaniOtomasyonuApp.Areas.admin.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HavaalaniOtomasyonuApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Session["ActiveUser"] != null)
            {
                return View();
            }
            else
            {
                return Redirect("/admin");
            }
        }

        public ActionResult Anasayfa()
        {    
                return View();
           
        }

        public ActionResult Ckeditor()
        {
            if (Session["ActiveUser"] != null)
            {
                return View();
            }
            else
            {
                return Redirect("/admin");
            }

        }

    }
}