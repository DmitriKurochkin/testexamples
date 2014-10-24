using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using testmvc.Models;

namespace testmvc.Api
{
    /*
    To add a route for this controller, merge these statements into the Register method of the WebApiConfig class. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using testmvc.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<UserModel>("Ousers");
    config.Routes.MapODataRoute("odata", "odata", builder.GetEdmModel());
    */
    public class OusersController : ODataController
    {
        private UsersContext db = new UsersContext();

        // GET odata/Ousers
        [Queryable]
        public IQueryable<UserModel> GetOusers()
        {
            return db.Users;
        }

        // GET odata/Ousers(5)
        [Queryable]
        public SingleResult<UserModel> GetUserModel([FromODataUri] int key)
        {
            return SingleResult.Create(db.Users.Where(usermodel => usermodel.UserId == key));
        }

        // PUT odata/Ousers(5)
        public IHttpActionResult Put([FromODataUri] int key, UserModel usermodel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (key != usermodel.UserId)
            {
                return BadRequest();
            }

            db.Entry(usermodel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserModelExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(usermodel);
        }

        // POST odata/Ousers
        public IHttpActionResult Post(UserModel usermodel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Users.Add(usermodel);
            db.SaveChanges();

            return Created(usermodel);
        }

        // PATCH odata/Ousers(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<UserModel> patch)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            UserModel usermodel = db.Users.Find(key);
            if (usermodel == null)
            {
                return NotFound();
            }

            patch.Patch(usermodel);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserModelExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(usermodel);
        }

        // DELETE odata/Ousers(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            UserModel usermodel = db.Users.Find(key);
            if (usermodel == null)
            {
                return NotFound();
            }

            db.Users.Remove(usermodel);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserModelExists(int key)
        {
            return db.Users.Count(e => e.UserId == key) > 0;
        }
    }
}
