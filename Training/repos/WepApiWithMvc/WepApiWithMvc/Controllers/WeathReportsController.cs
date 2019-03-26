using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WepApiWithMvc.Models;

namespace WepApiWithMvc.Controllers
{
    public class WeathReportsController : Controller
    {
        private WeatherReportsContainer db = new WeatherReportsContainer();

        // GET: WeathReports
        public ActionResult Index()
        {
            return View(db.WeathReports.ToList());
        }

        // GET: WeathReports/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeathReports weathReports = db.WeathReports.Find(id);
            if (weathReports == null)
            {
                return HttpNotFound();
            }
            return View(weathReports);
        }

        // GET: WeathReports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WeathReports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Country,State,City,Temp")] WeathReports weathReports)
        {
            if (ModelState.IsValid)
            {
                db.WeathReports.Add(weathReports);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(weathReports);
        }

        // GET: WeathReports/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeathReports weathReports = db.WeathReports.Find(id);
            if (weathReports == null)
            {
                return HttpNotFound();
            }
            return View(weathReports);
        }

        // POST: WeathReports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Country,State,City,Temp")] WeathReports weathReports)
        {
            if (ModelState.IsValid)
            {
                db.Entry(weathReports).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(weathReports);
        }

        // GET: WeathReports/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeathReports weathReports = db.WeathReports.Find(id);
            if (weathReports == null)
            {
                return HttpNotFound();
            }
            return View(weathReports);
        }

        // POST: WeathReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WeathReports weathReports = db.WeathReports.Find(id);
            db.WeathReports.Remove(weathReports);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
