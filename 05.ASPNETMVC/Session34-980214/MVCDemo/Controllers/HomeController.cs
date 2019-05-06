using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewData["Name"] = "Chandler";
            //var x = ViewData["Name"];
            //ViewBag.Family = "Bing";
            //ViewBag.PersonData = new Person() { Name = "Monica", Family = "Geller" };
            var person = new Person() {
                Name = "Monica",
                Family = "Geller",
                Courses = new List<Course>()
                {
                    new Course() { Title = "C#", Duration = 50 },
                    new Course() { Title = "SQL Server", Duration = 40 },
                    new Course() { Title = "Angular", Duration = 50 }
                }
            };
            return View(person);
        }
    }
}