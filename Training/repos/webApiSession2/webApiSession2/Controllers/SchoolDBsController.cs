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
using webApiSession2.Models;

namespace webApiSession2.Controllers
{
    public class SchoolDBsController : ApiController
    {
        private SchoolDBContainer db = new SchoolDBContainer();

        // GET: api/SchoolDBs
        public IQueryable<SchoolDB> GetSchoolDBs()
        {
            return db.SchoolDBs;
        }

        // GET: api/SchoolDBs/5
        [ResponseType(typeof(SchoolDB))]
        public IHttpActionResult GetSchoolDB(int id)
        {
            SchoolDB schoolDB = db.SchoolDBs.Find(id);
            if (schoolDB == null)
            {
                return NotFound();
            }

            return Ok(schoolDB);
        }

        // PUT: api/SchoolDBs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSchoolDB(int id, SchoolDB schoolDB)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != schoolDB.Id)
            {
                return BadRequest();
            }

            db.Entry(schoolDB).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SchoolDBExists(id))
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

        // POST: api/SchoolDBs
        [ResponseType(typeof(SchoolDB))]
        public IHttpActionResult PostSchoolDB(SchoolDB schoolDB)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SchoolDBs.Add(schoolDB);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = schoolDB.Id }, schoolDB);
        }

        // DELETE: api/SchoolDBs/5
        [ResponseType(typeof(SchoolDB))]
        public IHttpActionResult DeleteSchoolDB(int id)
        {
            SchoolDB schoolDB = db.SchoolDBs.Find(id);
            if (schoolDB == null)
            {
                return NotFound();
            }

            db.SchoolDBs.Remove(schoolDB);
            db.SaveChanges();

            return Ok(schoolDB);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SchoolDBExists(int id)
        {
            return db.SchoolDBs.Count(e => e.Id == id) > 0;
        }
    }
}