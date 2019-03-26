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
using WepApiWithMvc.Models;

namespace WepApiWithMvc.Controllers
{
    public class WeathReports1Controller : ApiController
    {
        private WeatherReportsContainer db = new WeatherReportsContainer();

        // GET: api/WeathReports1
        public IQueryable<WeathReports> GetWeathReports()
        {
            return db.WeathReports;
        }

        // GET: api/WeathReports1/5
        [ResponseType(typeof(WeathReports))]
        public IHttpActionResult GetWeathReports(int id)
        {
            WeathReports weathReports = db.WeathReports.Find(id);
            if (weathReports == null)
            {
                return NotFound();
            }

            return Ok(weathReports);
        }

        // PUT: api/WeathReports1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWeathReports(int id, WeathReports weathReports)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != weathReports.Id)
            {
                return BadRequest();
            }

            db.Entry(weathReports).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeathReportsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/WeathReports1
        [ResponseType(typeof(WeathReports))]
        public IHttpActionResult PostWeathReports(WeathReports weathReports)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.WeathReports.Add(weathReports);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = weathReports.Id }, weathReports);
        }

        // DELETE: api/WeathReports1/5
        [ResponseType(typeof(WeathReports))]
        public IHttpActionResult DeleteWeathReports(int id)
        {
            WeathReports weathReports = db.WeathReports.Find(id);
            if (weathReports == null)
            {
                return NotFound();
            }

            db.WeathReports.Remove(weathReports);
            db.SaveChanges();

            return Ok(weathReports);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WeathReportsExists(int id)
        {
            return db.WeathReports.Count(e => e.Id == id) > 0;
        }
    }
}