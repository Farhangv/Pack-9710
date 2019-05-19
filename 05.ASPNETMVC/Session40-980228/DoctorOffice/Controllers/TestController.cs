using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Hosting;
using System.Web.Http;

namespace DoctorOffice.Controllers
{
    public class TestController : ApiController
    {
        //[Route("~/api/MyApiMethod/{id}")]
        public IEnumerable<string> Get()
        {
            return new string[] { "C#", "PHP", "Java", "Python" };
        }

        public IHttpActionResult Post([FromBody]Person person)
        {
            using (StreamWriter sw = new StreamWriter(HostingEnvironment.MapPath("~/Data.txt"),true))
            {
                sw.WriteLine($"{person.Name},{person.Family}");
            }
            return Ok();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
    }
}
