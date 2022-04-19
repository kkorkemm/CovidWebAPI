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

    public class PatientsController : ApiController
    {
        private CovidSystemDBEntities db = new CovidSystemDBEntities();

        // GET: api/Patients
        [ResponseType(typeof(List<Patient>))]
        public IHttpActionResult GetPatient()
        {
            return Ok(db.Patient.ToList().ConvertAll(p => new PatientModel(p)));
        }

        // GET: api/Patients/5
        [ResponseType(typeof(Patient))]
        public IHttpActionResult GetPatient(int id)
        {
            Patient patient = db.Patient.Find(id);
            if (patient == null)
            {
                return NotFound();
            }

            return Ok(new PatientModel(patient));
        }
    }
}