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
    public class QuestionnnaresController : ApiController
    {
        private CovidSystemDBEntities db = new CovidSystemDBEntities();

        // GET: api/Questionnnares
        public IQueryable<Questionnnare> GetQuestionnnare()
        {
            return db.Questionnnare;
        }

        // GET: api/Questionnnares/5
        [ResponseType(typeof(Questionnnare))]
        public IHttpActionResult GetQuestionnnare(int id)
        {
            Questionnnare questionnnare = db.Questionnnare.Find(id);
            if (questionnnare == null)
            {
                return NotFound();
            }

            return Ok(questionnnare);
        }

        // PUT: api/Questionnnares/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutQuestionnnare(int id, Questionnnare questionnnare)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != questionnnare.ID)
            {
                return BadRequest();
            }

            db.Entry(questionnnare).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionnnareExists(id))
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

        // POST: api/Questionnnares
        [ResponseType(typeof(Questionnnare))]
        public IHttpActionResult PostQuestionnnare(Questionnnare questionnnare)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Questionnnare.Add(questionnnare);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = questionnnare.ID }, questionnnare);
        }

        // DELETE: api/Questionnnares/5
        [ResponseType(typeof(Questionnnare))]
        public IHttpActionResult DeleteQuestionnnare(int id)
        {
            Questionnnare questionnnare = db.Questionnnare.Find(id);
            if (questionnnare == null)
            {
                return NotFound();
            }

            db.Questionnnare.Remove(questionnnare);
            db.SaveChanges();

            return Ok(questionnnare);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool QuestionnnareExists(int id)
        {
            return db.Questionnnare.Count(e => e.ID == id) > 0;
        }
    }
}