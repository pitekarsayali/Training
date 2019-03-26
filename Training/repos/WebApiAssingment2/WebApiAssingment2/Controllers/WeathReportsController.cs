using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiAssingment2.Models;

namespace WebApiAssingment2.Controllers
{
    public class WeathReportsController : ApiController
    {
        private WeatherReportContainer db = new WeatherReportContainer();

        // GET: api/WeathReports
        public IQueryable<WeathReport> GetWeathReports()
        {
            return db.WeathReports;
        }

        // GET: api/WeathReports/5
        [ResponseType(typeof(WeathReport))]
        public IHttpActionResult GetWeathReport(int id)
        {
            WeathReport weathReport = db.WeathReports.Find(id);
            if (weathReport == null)
            {
                return NotFound();
            }

            return Ok(weathReport);
        }

        // PUT: api/WeathReports/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWeathReport(int id, WeathReport weathReport)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != weathReport.Id)
            {
                return BadRequest();
            }

            db.Entry(weathReport).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeathReportExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.Created);
        }

        // POST: api/WeathReports
        [ResponseType(typeof(WeathReport))]
        public IHttpActionResult PostWeathReport(WeathReport weathReport)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.WeathReports.Add(weathReport);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = weathReport.Id }, weathReport);
        }

        // DELETE: api/WeathReports/5
        [ResponseType(typeof(WeathReport))]
        public IHttpActionResult DeleteWeathReport(int id)
        {
            WeathReport weathReport = db.WeathReports.Find(id);
            if (weathReport == null)
            {
                return NotFound();
            }

            db.WeathReports.Remove(weathReport);
            db.SaveChanges();

            return Ok(weathReport);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WeathReportExists(int id)
        {
            return db.WeathReports.Count(e => e.Id == id) > 0;
        }
    }
}