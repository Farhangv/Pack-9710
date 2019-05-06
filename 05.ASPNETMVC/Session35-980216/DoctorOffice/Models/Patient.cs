using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoctorOffice.Models
{
    public class Patient:Person
    {
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public ICollection<File> Files { get; set; }

    }
}