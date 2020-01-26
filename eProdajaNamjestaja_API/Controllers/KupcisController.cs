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
using eProdajaNamjestaja_API.Models;

namespace eProdajaNamjestaja_API.Controllers
{
    public class KupcisController : ApiController
    {
        private eNamjestajEntities db = new eNamjestajEntities();

        // GET: api/Kupcis
        public IQueryable<Kupci> GetKupci()
        {
            return db.Kupci;
        }

        // GET: api/Kupcis/5
        [ResponseType(typeof(Kupci))]
        public IHttpActionResult GetKupci(int id)
        {
            Kupci kupci = db.Kupci.Find(id);
            if (kupci == null)
            {
                return NotFound();
            }

            return Ok(kupci);
        }

        [Route("api/Kupcis/GetKupciByUsername/{name?}")]
        [HttpGet]
        public IHttpActionResult GetKupciByUsername(string name = "")
        {
            Kupci kupci = db.Kupci.Where(x => x.KorisnickoIme == name && x.Statuss == true).FirstOrDefault();

            if (kupci == null)
            {
                return NotFound();
            }

            return Ok(kupci);
        }

        // PUT: api/Kupcis/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKupci(int id, Kupci kupci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kupci.KupacID)
            {
                return BadRequest();
            }

            db.Entry(kupci).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KupciExists(id))
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

        // POST: api/Kupcis
        [HttpPost]
        [ResponseType(typeof(Kupci))]
        public IHttpActionResult PostKupci(Kupci kupci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Kupci.Add(kupci);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = kupci.KupacID }, kupci);
        }

        // DELETE: api/Kupcis/5
        [ResponseType(typeof(Kupci))]
        public IHttpActionResult DeleteKupci(int id)
        {
            Kupci kupci = db.Kupci.Find(id);
            if (kupci == null)
            {
                return NotFound();
            }

            db.Kupci.Remove(kupci);
            db.SaveChanges();

            return Ok(kupci);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KupciExists(int id)
        {
            return db.Kupci.Count(e => e.KupacID == id) > 0;
        }
    }
}