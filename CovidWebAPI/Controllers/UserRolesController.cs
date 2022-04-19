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
    public class UserRolesController : ApiController
    {
        private CovidSystemDBEntities db = new CovidSystemDBEntities();

        // GET: api/UserRoles
        [ResponseType(typeof(List<UserRole>))]
        public IHttpActionResult GetUserRole()
        {
            return Ok(db.UserRole.ToList());
        }

        // GET: api/UserRoles/5
        [ResponseType(typeof(UserRole))]
        public IHttpActionResult GetUserRole(byte id)
        {
            UserRole userRole = db.UserRole.Find(id);
            if (userRole == null)
            {
                return NotFound();
            }

            return Ok(userRole);
        }
    }
}