using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcCrudWithScaf.Controllers
{
    public class empController : Controller
    {
        // GET: emp
        public ActionResult Index()
        {
            return View();
        }
        //public string Display()
        //{
        //    return "first mvc application........";
        //}
    }
}