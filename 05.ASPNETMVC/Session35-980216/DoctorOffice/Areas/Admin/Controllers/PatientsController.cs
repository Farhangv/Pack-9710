using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DoctorOffice.Models;

namespace DoctorOffice.Areas.Admin.Controllers
{
    public class PatientsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/Patients
        public ActionResult Index()
        {
            var people = db.People.Include(p => p.ApplicationUser);
            return View(people.ToList());
        }

        // GET: Admin/Patients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.People.Find(id) as Patient;
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // GET: Admin/Patients/Create
        public ActionResult Create()
        {
            //ViewBag.Id = new SelectList(db.ApplicationUsers, "Id", "HomePhoneNumber");
            return View();
        }

        // POST: Admin/Patients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Family,NationalCode,BirthDate,Gender")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                db.People.Add(patient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.Id = new SelectList(db.ApplicationUsers, "Id", "HomePhoneNumber", patient.Id);
            return View(patient);
        }

        // GET: Admin/Patients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.People.Find(id) as Patient;
            if (patient == null)
            {
                return HttpNotFound();
            }
            //ViewBag.Id = new SelectList(db.ApplicationUsers, "Id", "HomePhoneNumber", patient.Id);
            return View(patient);
        }

        // POST: Admin/Patients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Family,NationalCode,BirthDate,Gender")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //ViewBag.Id = new SelectList(db.ApplicationUsers, "Id", "HomePhoneNumber", patient.Id);
            return View(patient);
        }

        // GET: Admin/Patients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.People.Find(id) as Patient;
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // POST: Admin/Patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Patient patient = db.People.Find(id) as Patient;
            db.People.Remove(patient);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
