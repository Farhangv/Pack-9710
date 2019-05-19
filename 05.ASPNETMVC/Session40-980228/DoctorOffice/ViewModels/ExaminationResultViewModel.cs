using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOffice.ViewModels
{
    public class ExaminationResultViewModel
    {
        public int PatientId { get; set; }
        public HttpPostedFileBase File { get; set; }
    }
}