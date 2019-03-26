using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace viewdata.Controllers
{
    public class ViewbagController : Controller
    {
        // GET: Viewbag
        public ActionResult Index()
        {
         
            return View();
        }
    }
}