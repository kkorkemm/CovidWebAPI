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

    public class VaccinationPointsController : ApiController
    {
        private CovidSystemDBEntities db = new CovidSystemDBEntities();

        // GET: api/VaccinationPoints
        [ResponseType(typeof(List<VaccinationPoint>))]
        public IHttpActionResult GetVaccinationPoint()
        {
            return Ok(db.VaccinationPoint.ToList().ConvertAll(p => new VaccinationPointsModel(p)));
        }

        // GET: api/VaccinationPoints/5
        [ResponseType(typeof(VaccinationPoint))]
        public IHttpActionResult GetVaccinationPoint(int id)
        {
            VaccinationPoint vaccinationPoint = db.VaccinationPoint.Find(id);
            if (vaccinationPoint == null)
            {
                return NotFound();
            }

            return Ok(vaccinationPoint);
        }

        // PUT: api/VaccinationPoints/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVaccinationPoint(int id, VaccinationPoint vaccinationPoint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vaccinationPoint.ID)
            {
                return BadRequest();
            }

            db.Entry(vaccinationPoint).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VaccinationPointExists(id))
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

        // POST: api/VaccinationPoints
        [ResponseType(typeof(VaccinationPoint))]
        public IHttpActionResult PostVaccinationPoint(VaccinationPoint vaccinationPoint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VaccinationPoint.Add(vaccinationPoint);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vaccinationPoint.ID }, vaccinationPoint);
        }

        // DELETE: api/VaccinationPoints/5
        [ResponseType(typeof(VaccinationPoint))]
        public IHttpActionResult DeleteVaccinationPoint(int id)
        {
            VaccinationPoint vaccinationPoint = db.VaccinationPoint.Find(id);
            if (vaccinationPoint == null)
            {
                return NotFound();
            }

            db.VaccinationPoint.Remove(vaccinationPoint);
            db.SaveChanges();

            return Ok(vaccinationPoint);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VaccinationPointExists(int id)
        {
            return db.VaccinationPoint.Count(e => e.ID == id) > 0;
        }
    }
}