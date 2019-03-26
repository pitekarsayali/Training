using mvcCrudWithScaf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace mvcCrudWithScaf.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        private StudInfoContainer db = new StudInfoContainer();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult show()
        {

            return View(db.StudInformations.ToList());
        }
        public ActionResult Add()
        {

            return View();
        }
        public ActionResult CreateEmp()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEmp([Bind(Include = "Id,Name,Salary")] StudInformation stud)
        {
            if (ModelState.IsValid)
            {
                db.StudInformations.Add(stud);
                db.SaveChanges();
                return RedirectToAction("show");
            }

            return View(stud);
        }
        public ActionResult DeleteEmp(int?id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudInformation stud = db.StudInformations.Find(id);
            if (StudInformation == null)
            {
                return HttpNotFound();
            }
            db.StudInformations.Remove(StudInformation);
            db.SaveChanges();
            return RedirectToAction("show");
        }



    }
}