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
using DoctorOffice.Models;
using DoctorOffice.ServiceModels;

namespace DoctorOffice.Controllers
{
    public class PatientsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Patients
        public PatientDto[] GetPatients()
        {
            return db.Patients
                .Select(p => new PatientDto() {
                Id = p.Id,
                Name = p.Name,
                Family = p.Family,
                BirthDate = p.BirthDate
            }).ToArray();
        }

        // GET: api/Patients/5
        [ResponseType(typeof(Patient))]
        public async Task<IHttpActionResult> GetPatient(int id)
        {
            Patient patient = await db.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }

            return Ok(patient);
        }

        // PUT: api/Patients/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPatient([FromUri]int id, [FromBody]Patient patient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != patient.Id)
            {
                return BadRequest();
            }

            db.Entry(patient).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                //ex.Message;
                //ex.StackTrace;
                //ex.InnerException;
                if (!PatientExists(id))
                {
                    return NotFound();
                }
                else
                {
                    return StatusCode(HttpStatusCode.InternalServerError);
                }
            }
            catch (Exception)
            {

            }
            finally {

            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Patients
        [ResponseType(typeof(Patient))]
        public async Task<IHttpActionResult> PostPatient(Patient patient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Patients.Add(patient);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = patient.Id }, patient);
        }

        // DELETE: api/Patients/5
        [ResponseType(typeof(Patient))]
        public async Task<IHttpActionResult> DeletePatient(int id)
        {
            Patient patient = await db.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }

            db.People.Remove(patient);
            await db.SaveChangesAsync();

            return Ok(patient);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PatientExists(int id)
        {
            return db.People.Count(e => e.Id == id) > 0;
        }
    }
}