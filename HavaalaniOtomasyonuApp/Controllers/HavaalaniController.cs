using HavaalaniOtomasyonuApp.Areas.admin.Controllers;
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
    public class HavaalaniController : Controller
    {
        // GET: Havaalani
   
        public ActionResult Index()
        {
            if (LoginController.check == true)
            {
                using (HavaalaniContext ctx = new HavaalaniContext())
                {
                    var havaalanlari = ctx.Havaalanlari.ToList();
                    return View(havaalanlari);
                }
            }
            else
            {
                return Redirect("/admin");
            }
        }

        public ActionResult Ekle()
        {
            if (LoginController.check == true)
            {
                return View();
            }
            else
            {
                return Redirect("/admin");
            }
        }

        [HttpPost]
        public ActionResult Ekle(Havaalani h)
        {
            if (LoginController.check == true)
            {
                if (ModelState.IsValid)
                {
                    using (HavaalaniContext ctx = new HavaalaniContext())
                    {
                        ctx.Havaalanlari.Add(h);
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
            if (LoginController.check == true)
            {
                if (ModelState.IsValid)
                {
                    using (HavaalaniContext ctx = new HavaalaniContext())
                    {
                        var ha = ctx.Havaalanlari.Find(id);

                        return View(ha);
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
        public ActionResult Duzenle(Havaalani ha)
        {
            if (LoginController.check == true)
            {
                if (ModelState.IsValid)
                {
                    using (HavaalaniContext ctx = new HavaalaniContext())
                    {
                        ctx.Entry(ha).State = EntityState.Modified;
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

                if (LoginController.check == true)
                {
                    var ha = ctx.Havaalanlari.Find(id);
                    ctx.Havaalanlari.Remove(ha);
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