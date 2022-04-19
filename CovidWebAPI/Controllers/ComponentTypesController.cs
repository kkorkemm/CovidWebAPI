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
    public class ComponentTypesController : ApiController
    {
        private CovidSystemDBEntities db = new CovidSystemDBEntities();

        // GET: api/ComponentTypes
        public IQueryable<ComponentType> GetComponentType()
        {
            return db.ComponentType;
        }

        // GET: api/ComponentTypes/5
        [ResponseType(typeof(ComponentType))]
        public IHttpActionResult GetComponentType(int id)
        {
            ComponentType componentType = db.ComponentType.Find(id);
            if (componentType == null)
            {
                return NotFound();
            }

            return Ok(componentType);
        }
    }
}