using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcPrac.Controllers
{
    public class ViewBagController : Controller
    {
        // GET: ViewBag
        public ActionResult Index()
        {
            ViewBag.Brandlist = new List<string>()
            {"Puma",
            "Sparks",
            "Bata"
            };
            return View();
        }
        public ActionResult ViewdataMethod()
        {
            ViewData["Brandlist"] = new List<string>()
            {"Puma",
            "Sparks",
            "Bata"
            };
            return View();
        }
        public ActionResult TempdataMethod()
        {
            TempData["str"] = "This is temp data";
            return RedirectToAction("FirstMethod");
        }
        public ActionResult FirstMethod()
        {
            TempData["new"] = TempData["str"];
            return View();
        }

    }
}