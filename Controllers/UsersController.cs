using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using KnowYourCircleWebServiceApi.Models;

namespace KnowYourCircleWebServiceApi.Controllers
{
    public class UsersController : ApiController
    {
        private modelEntities db = new modelEntities();

        // GET: api/Users1
        public IQueryable<Users1> GetUsers1()
        {
            return db.Users1;
        }

        // GET: api/Users1/5
        [ResponseType(typeof(Users1))]
        public async Task<IHttpActionResult> GetUsers1(int id)
        {
            Users1 users1 = await db.Users1.FindAsync(id);
            if (users1 == null)
            {
                return NotFound();
            }

            return Ok(users1);
        }

        // PUT: api/Users1/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUsers1(int id, Users1 users1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != users1.Id)
            {
                return BadRequest();
            }

            db.Entry(users1).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Users1Exists(id))
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

        // POST: api/Users1
        [ResponseType(typeof(Users1))]
        public async Task<IHttpActionResult> PostUsers1(Users1 users1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Users1.Add(users1);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = users1.Id }, users1);
        }

        // DELETE: api/Users1/5
        [ResponseType(typeof(Users1))]
        public async Task<IHttpActionResult> DeleteUsers1(int id)
        {
            Users1 users1 = await db.Users1.FindAsync(id);
            if (users1 == null)
            {
                return NotFound();
            }

            db.Users1.Remove(users1);
            await db.SaveChangesAsync();

            return Ok(users1);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Users1Exists(int id)
        {
            return db.Users1.Count(e => e.Id == id) > 0;
        }
    }
}