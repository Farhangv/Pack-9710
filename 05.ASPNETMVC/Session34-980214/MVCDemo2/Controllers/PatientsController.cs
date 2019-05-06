using MVCDemo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo2.Controllers
{
    public class PatientsController : Controller
    {
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        //public ActionResult Store(string name, string family, int age)
        public ActionResult Create(Patient patient)
        {
            //Patient p = new Patient()
            //{
            //    Name = name,
            //    Family = family,
            //    Age = age
            //};
            HMSContext ctx = new HMSContext();
            ctx.Patients.Add(patient);
            ctx.SaveChanges();
            return new HttpStatusCodeResult(201);
        }
    }
}