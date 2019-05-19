using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoctorOffice.Models
{
    public class Patient:Person
    {
        [Display(Name = "تاریخ تولد")]
        [Required(ErrorMessage = "ورود تاریخ تولد اجباری است")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "جنسیت")]
        public Gender Gender { get; set; }
        public ICollection<File> Files { get; set; }

    }
}