using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcprac2.Controllers
{
    public class viewbagController : Controller
    {
        // GET: viewbag
        public ActionResult Index()
        {
            ViewBag.Message="Hellllo";
            ViewData["x"] = "this is view data";
            return View();
        }
        public ActionResult Display()
        {

            return View();
        }
}
    }