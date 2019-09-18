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
using RespitronDay2.Models;

namespace RespitronDay2.Controllers
{
    public class ConsumptionHistoriesController : ApiController
    {
        private RespitronDay2Context db = new RespitronDay2Context();

        // GET: api/ConsumptionHistories
        public IQueryable<ConsumptionHistory> GetConsumptionHistories()
        {
            return db.ConsumptionHistories;
        }

        // GET: api/ConsumptionHistories/5
        [ResponseType(typeof(ConsumptionHistory))]
        public async Task<IHttpActionResult> GetConsumptionHistory(int id)
        {
            //ConsumptionHistory consumptionHistory = await db.ConsumptionHistories.FindAsync(id);
            ConsumptionHistory consumptionHistory = await db.ConsumptionHistories.Include(p => p.Patient)
                .Where(p => p.Id == id)
                .FirstOrDefaultAsync();
            if (consumptionHistory == null)
            {
                return NotFound();
            }

            return Ok(consumptionHistory);
        }

        // PUT: api/ConsumptionHistories/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutConsumptionHistory(int id, ConsumptionHistory consumptionHistory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != consumptionHistory.Id)
            {
                return BadRequest();
            }

            db.Entry(consumptionHistory).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsumptionHistoryExists(id))
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

        // POST: api/ConsumptionHistories
        [ResponseType(typeof(ConsumptionHistory))]
        public async Task<IHttpActionResult> PostConsumptionHistory(ConsumptionHistory consumptionHistory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ConsumptionHistories.Add(consumptionHistory);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = consumptionHistory.Id }, consumptionHistory);
        }

        // DELETE: api/ConsumptionHistories/5
        [ResponseType(typeof(ConsumptionHistory))]
        public async Task<IHttpActionResult> DeleteConsumptionHistory(int id)
        {
            ConsumptionHistory consumptionHistory = await db.ConsumptionHistories.FindAsync(id);
            if (consumptionHistory == null)
            {
                return NotFound();
            }

            db.ConsumptionHistories.Remove(consumptionHistory);
            await db.SaveChangesAsync();

            return Ok(consumptionHistory);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ConsumptionHistoryExists(int id)
        {
            return db.ConsumptionHistories.Count(e => e.Id == id) > 0;
        }
    }
}