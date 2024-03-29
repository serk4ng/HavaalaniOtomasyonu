﻿using HavaalaniOtomasyonuApp.Areas.admin.Controllers;
using HavaalaniOtomasyonuApp.DAL;
using HavaalaniOtomasyonuApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HavaalaniOtomasyonuApp.Controllers
{
    public class UcakController : Controller
    {
        // GET: Ucak
        public ActionResult Index()
        {
            if (Session["ActiveUser"] != null)
            {
                using (HavaalaniContext ctx = new HavaalaniContext())
                {
                    var ucaklar = ctx.Ucaklar.ToList();
                    return View(ucaklar);
                }
            }
            else
            {
                return Redirect("/admin");
            }
        }

        public ActionResult Ekle()
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

        [HttpPost]
        public ActionResult Ekle(Ucak u)
        {
            if (Session["ActiveUser"] != null)
            {
                if (ModelState.IsValid)
                {
                    using (HavaalaniContext ctx = new HavaalaniContext())
                    {
                        ctx.Ucaklar.Add(u);
                        int sonuc = ctx.SaveChanges();
                        if (sonuc > 0)
                        {
                            return RedirectToAction("Index");
                            //return View();
                        }
                    }
                }

                return View();

            }
            else
            {
                return Redirect("/admin");
            }
        }

        public ActionResult Duzenle(int? id)
        {
            if (Session["ActiveUser"] != null)
            {
                if (ModelState.IsValid)
                {
                    using (HavaalaniContext ctx = new HavaalaniContext())
                    {
                        var u = ctx.Ucaklar.Find(id);

                        return View(u);
                    }
                }
                return View();
            }
            else
            {
                return Redirect("/admin");
            }
        }

        [HttpPost]
        public ActionResult Duzenle(Ucak u)
        {
            if (Session["ActiveUser"] != null)
            {
                if (ModelState.IsValid)
                {
                    using (HavaalaniContext ctx = new HavaalaniContext())
                    {
                        ctx.Entry(u).State = EntityState.Modified;
                        int sonuc = ctx.SaveChanges();
                        if (sonuc > 0)
                        {
                            return RedirectToAction("Index");
                        }
                    }
                }
                return View();
            }
            else
            {
                return Redirect("/admin");
            }
        }

        public ActionResult Sil(int? id)
        {
            using (HavaalaniContext ctx = new HavaalaniContext())
            {

                if (Session["ActiveUser"] != null)
                {
                    var u = ctx.Ucaklar.Find(id);
                    ctx.Ucaklar.Remove(u);
                    ctx.SaveChanges();
                    return RedirectToAction("Index");
                }

                else
                {
                    return Redirect("/admin");
                }
            }


        }
    }
}