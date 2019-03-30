using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeslaPower.Models;

namespace TeslaPower.Controllers
{
    public class DesignController : Controller
    {
        TeslaEntities te = new TeslaEntities();
        public ActionResult Index()
        {
            var designs = te.Designs.Where(d => d.status == true);

            return View(designs);
        }
        public ViewResult ViewDesign()
        {
            ViewBag.DiNo = new SelectList(te.Designs, "DiNo", "DiNo");
            return View();
        }
        [HttpPost]
        public ActionResult ViewDesign(Design d)
        {
            return RedirectToAction("ViewDesignByID", new { id = d.DiNo });
        }
        public ActionResult ViewDesignByID(string id)
        {
            ViewBag.DiNo = new SelectList(te.Designs, "DiNo", "DiNo");
            Design d = te.Designs.Find(id);
            return View(d);
        }
        [HttpPost]
        public ActionResult ViewDesignByID(Design d)
        {
            ViewBag.DiNo = new SelectList(te.Designs, "DiNo", "DiNo");
            Design d1 = te.Designs.Find(d.DiNo);
            return View(d1);
        }
        [HttpGet]
        public ActionResult AddDesign()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDesign(Design d)
        {
            d.status = true;
            te.Designs.Add(d);
            te.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteDesign(string DiNo)
        {
            Design d = te.Designs.Find(DiNo);
            d.status = false;
            te.Entry(d).State = System.Data.Entity.EntityState.Modified;
            te.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}