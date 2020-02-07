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
    public class NoticeBoardsController : ApiController
    {
        private modelEntities db = new modelEntities();

        // GET: api/NoticeBoards
        public IQueryable<NoticeBoard> GetNoticeBoards()
        {
            return db.NoticeBoards;
        }

        // GET: api/NoticeBoards/5
        [ResponseType(typeof(NoticeBoard))]
        public async Task<IHttpActionResult> GetNoticeBoard(int id)
        {
            NoticeBoard noticeBoard = await db.NoticeBoards.FindAsync(id);
            if (noticeBoard == null)
            {
                return NotFound();
            }

            return Ok(noticeBoard);
        }

        // PUT: api/NoticeBoards/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutNoticeBoard(int id, NoticeBoard noticeBoard)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != noticeBoard.Id)
            {
                return BadRequest();
            }

            db.Entry(noticeBoard).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NoticeBoardExists(id))
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

        // POST: api/NoticeBoards
        [ResponseType(typeof(NoticeBoard))]
        public async Task<IHttpActionResult> PostNoticeBoard(NoticeBoard noticeBoard)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.NoticeBoards.Add(noticeBoard);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = noticeBoard.Id }, noticeBoard);
        }

        // DELETE: api/NoticeBoards/5
        [ResponseType(typeof(NoticeBoard))]
        public async Task<IHttpActionResult> DeleteNoticeBoard(int id)
        {
            NoticeBoard noticeBoard = await db.NoticeBoards.FindAsync(id);
            if (noticeBoard == null)
            {
                return NotFound();
            }

            db.NoticeBoards.Remove(noticeBoard);
            await db.SaveChangesAsync();

            return Ok(noticeBoard);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NoticeBoardExists(int id)
        {
            return db.NoticeBoards.Count(e => e.Id == id) > 0;
        }
    }
}