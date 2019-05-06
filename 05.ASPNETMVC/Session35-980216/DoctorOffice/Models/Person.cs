using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOffice.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string NationalCode { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}