using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DoctorOffice.Models;
using DoctorOffice.ViewModels;
using MD.PersianDateTime;
using M = DoctorOffice.Models;

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
        public ActionResult Create(
            [Bind(Include = "Id,Name,Family,NationalCode,PersianBirthDate,Gender")] PatientsCreateViewModel viewModel)
        {
            if(viewModel.Name == "برنامه نویس" && viewModel.Family == "سی شارپ")
            {
                ModelState.AddModelError("Name", "نام وارد شده مجاز نیست");
                ModelState.AddModelError("Family", "نام خانوادگی وارد شده مجاز نیست");
                ModelState.AddModelError("", "ترکیب نام و نام خانوادگی مجاز نیست");
            }
            if (ModelState.IsValid) // Recieved Model Has Valid Values
            {
                var patient = new Patient()
                {
                    Name = viewModel.Name,
                    Family = viewModel.Family,
                    BirthDate = PersianDateTime.Parse(viewModel.PersianBirthDate).ToDateTime(),
                    Gender = viewModel.Gender,
                    NationalCode = viewModel.NationalCode
                };

                ctx.Patients.Add(patient);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(viewModel);
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

        public ActionResult SubmitExaminationResult()
        {
            
            var patients = new SelectList(ctx.Patients.ToList()
                .Select(p => new { Id = p.Id, FullName = $"{p.Name} {p.Family}" }), "Id", "FullName");
            ViewBag.PatientId = patients;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitExaminationResult(ExaminationResultViewModel viewModel)
        {
            if (viewModel.File.ContentLength / 1024 / 1024 > 2)
            {
                ModelState.AddModelError("File", "حجم فایل ارسالی باید کمتر از ۲ مگابایت باشد");
            }
            //...
            if (ModelState.IsValid)
            {
                var patient = ctx.Patients.Find(viewModel.PatientId);
                if (patient.Files == null)
                    patient.Files = new List<M.File>();

                var file = new M.File();
                file.OriginalFileName = viewModel.File.FileName;
                file.Extension = System.IO.Path.GetExtension(viewModel.File.FileName);
                file.Size = viewModel.File.ContentLength;
                file.ContentType = viewModel.File.ContentType;
                using (MemoryStream ms = new MemoryStream())
                {
                    viewModel.File.InputStream.CopyTo(ms);
                    file.Content = ms.ToArray();
                }

                patient.Files.Add(file);
                ctx.SaveChanges();
                TempData["Message"] = "فایل بیمار با موفقیت افزوده شد";
                return RedirectToAction("Edit", "Patients", new { id = viewModel.PatientId });
            }

            var patients = new SelectList(ctx.Patients.ToList()
                .Select(p => new { Id = p.Id, FullName = $"{p.Name} {p.Family}" }), "Id", "FullName", viewModel.PatientId);
            ViewBag.PatientId = patients;
            return View(viewModel);

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
