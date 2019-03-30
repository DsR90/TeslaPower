using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeslaPower.Models;

namespace TeslaPower.Controllers
{
    public class StageController : Controller
    {
        TeslaEntities te = new TeslaEntities();
        public ActionResult CaEntry()
        {
            ViewBag.DiNO = new SelectList(te.Designs.Where(d => d.status == true), "DiNo", "DiNo");
            return View();
        }
        [HttpPost]
        public ActionResult CaEntry(CA ca)
        {
            return View();
        }
    }
}