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
    public class OptionsController : ApiController
    {
        private modelEntities db = new modelEntities();

        // GET: api/Options
        public IQueryable<Options1> GetOptions1()
        {
            return db.Options1;
        }

        // GET: api/Options/5
        [ResponseType(typeof(Options1))]
        public async Task<IHttpActionResult> GetOptions1(int id)
        {
            Options1 options1 = await db.Options1.FindAsync(id);
            if (options1 == null)
            {
                return NotFound();
            }

            return Ok(options1);
        }

        // PUT: api/Options/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutOptions1(int id, Options1 options1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != options1.Id)
            {
                return BadRequest();
            }

            db.Entry(options1).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Options1Exists(id))
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

        // POST: api/Options
        [ResponseType(typeof(Options1))]
        public async Task<IHttpActionResult> PostOptions1(Options1 options1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Options1.Add(options1);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = options1.Id }, options1);
        }

        // DELETE: api/Options/5
        [ResponseType(typeof(Options1))]
        public async Task<IHttpActionResult> DeleteOptions1(int id)
        {
            Options1 options1 = await db.Options1.FindAsync(id);
            if (options1 == null)
            {
                return NotFound();
            }

            db.Options1.Remove(options1);
            await db.SaveChangesAsync();

            return Ok(options1);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Options1Exists(int id)
        {
            return db.Options1.Count(e => e.Id == id) > 0;
        }
    }
}