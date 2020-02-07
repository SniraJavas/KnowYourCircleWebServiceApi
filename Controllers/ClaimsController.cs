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
    public class ClaimsController : ApiController
    {
        private modelEntities db = new modelEntities();

        // GET: api/Claims
        public IQueryable<Claim> GetClaims()
        {
            return db.Claims;
        }

        // GET: api/Claims/5
        [ResponseType(typeof(Claim))]
        public async Task<IHttpActionResult> GetClaim(int id)
        {
            Claim claim = await db.Claims.FindAsync(id);
            if (claim == null)
            {
                return NotFound();
            }

            return Ok(claim);
        }

        // PUT: api/Claims/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClaim(int id, Claim claim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != claim.Id)
            {
                return BadRequest();
            }

            db.Entry(claim).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClaimExists(id))
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

        // POST: api/Claims
        [ResponseType(typeof(Claim))]
        public async Task<IHttpActionResult> PostClaim(Claim claim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Claims.Add(claim);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = claim.Id }, claim);
        }

        // DELETE: api/Claims/5
        [ResponseType(typeof(Claim))]
        public async Task<IHttpActionResult> DeleteClaim(int id)
        {
            Claim claim = await db.Claims.FindAsync(id);
            if (claim == null)
            {
                return NotFound();
            }

            db.Claims.Remove(claim);
            await db.SaveChangesAsync();

            return Ok(claim);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClaimExists(int id)
        {
            return db.Claims.Count(e => e.Id == id) > 0;
        }
    }
}