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
using CovidWebAPI.Base;

namespace CovidWebAPI.Controllers
{
    using Models;

    public class TimeTablesController : ApiController
    {
        private CovidSystemDBEntities db = new CovidSystemDBEntities();

        // GET: api/TimeTables
        [ResponseType(typeof(List<TimeTable>))]
        public IHttpActionResult GetTimeTable()
        {
            return Ok(db.TimeTable.ToList().ConvertAll(p => new TimeTableModel(p)));
        }

        // GET: api/TimeTables/5
        [ResponseType(typeof(TimeTable))]
        public IHttpActionResult GetTimeTable(long id)
        {
            TimeTable timeTable = db.TimeTable.Find(id);
            if (timeTable == null)
            {
                return NotFound();
            }

            return Ok(timeTable);
        }

        // PUT: api/TimeTables/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTimeTable(long id, TimeTable timeTable)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != timeTable.ID)
            {
                return BadRequest();
            }

            db.Entry(timeTable).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TimeTableExists(id))
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

        // POST: api/TimeTables
        [ResponseType(typeof(TimeTable))]
        public IHttpActionResult PostTimeTable(TimeTable timeTable)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TimeTable.Add(timeTable);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = timeTable.ID }, timeTable);
        }

        // DELETE: api/TimeTables/5
        [ResponseType(typeof(TimeTable))]
        public IHttpActionResult DeleteTimeTable(long id)
        {
            TimeTable timeTable = db.TimeTable.Find(id);
            if (timeTable == null)
            {
                return NotFound();
            }

            db.TimeTable.Remove(timeTable);
            db.SaveChanges();

            return Ok(timeTable);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TimeTableExists(long id)
        {
            return db.TimeTable.Count(e => e.ID == id) > 0;
        }
    }
}