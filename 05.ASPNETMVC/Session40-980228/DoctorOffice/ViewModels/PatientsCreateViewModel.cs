using DoctorOffice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOffice.ViewModels
{
    public class PatientsCreateViewModel
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string PersianBirthDate { get; set; }
        public string NationalCode { get; set; }
        public Gender Gender { get; set; }
    }
}