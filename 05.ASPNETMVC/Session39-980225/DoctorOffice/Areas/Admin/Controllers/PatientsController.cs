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
    [Authorize/*(Roles = "Admin,Patient")*/]
    public class PatientsController : Controller
    {
        private ApplicationDbContext ctx = new ApplicationDbContext();

        public ActionResult Index()
        {
            var patients = ctx.Patients;
            return View(patients.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = ctx.People.Find(id) as Patient;
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Family,NationalCode,BirthDate,Gender")] Patient patient)
        {
            if(patient.Name == "برنامه نویس" && patient.Family == "سی شارپ")
            {
                ModelState.AddModelError("Name", "نام وارد شده مجاز نیست");
                ModelState.AddModelError("Family", "نام خانوادگی وارد شده مجاز نیست");
                ModelState.AddModelError("", "ترکیب نام و نام خانوادگی مجاز نیست");
            }
            if (ModelState.IsValid) // Recieved Model Has Valid Values
            {
                ctx.Patients.Add(patient);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patient);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = ctx.Patients.Find(id);
            
            if (patient == null)
            {
                return HttpNotFound();
                //return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            //Session["PatientId"] = id;
            return View(patient);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Family,NationalCode,BirthDate,Gender")] Patient patient)
        {
            //if (int.Parse(Session["PatientId"].ToString()) == patient.Id)
            //{
                if (ModelState.IsValid)
                {
                    //var dbPatient = ctx.Patients.Find(patient.Id);
                    //dbPatient.Name = patient.Name;
                    //dbPatient.Family = patient.Family;
                    //...

                    ctx.Entry(patient).State = EntityState.Modified;
                    ctx.SaveChanges();
                    //Session["PatientId"] = null;
                    return RedirectToAction("Index");

                }
            //}
            return View(patient);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = ctx.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Patient patient = ctx.Patients.Find(id);
            ctx.Patients.Remove(patient);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ctx.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
