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
    public class LunchOrdersController : ApiController
    {
        private modelEntities db = new modelEntities();

        // GET: api/LunchOrders
        public IQueryable<LunchOrder> GetLunchOrders()
        {
            return db.LunchOrders;
        }

        // GET: api/LunchOrders/5
        [ResponseType(typeof(LunchOrder))]
        public async Task<IHttpActionResult> GetLunchOrder(int id)
        {
            LunchOrder lunchOrder = await db.LunchOrders.FindAsync(id);
            if (lunchOrder == null)
            {
                return NotFound();
            }

            return Ok(lunchOrder);
        }

        // PUT: api/LunchOrders/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLunchOrder(int id, LunchOrder lunchOrder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lunchOrder.Id)
            {
                return BadRequest();
            }

            db.Entry(lunchOrder).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LunchOrderExists(id))
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

        // POST: api/LunchOrders
        [ResponseType(typeof(LunchOrder))]
        public async Task<IHttpActionResult> PostLunchOrder(LunchOrder lunchOrder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LunchOrders.Add(lunchOrder);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = lunchOrder.Id }, lunchOrder);
        }

        // DELETE: api/LunchOrders/5
        [ResponseType(typeof(LunchOrder))]
        public async Task<IHttpActionResult> DeleteLunchOrder(int id)
        {
            LunchOrder lunchOrder = await db.LunchOrders.FindAsync(id);
            if (lunchOrder == null)
            {
                return NotFound();
            }

            db.LunchOrders.Remove(lunchOrder);
            await db.SaveChangesAsync();

            return Ok(lunchOrder);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LunchOrderExists(int id)
        {
            return db.LunchOrders.Count(e => e.Id == id) > 0;
        }
    }
}