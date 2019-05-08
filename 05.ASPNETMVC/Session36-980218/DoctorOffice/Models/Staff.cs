using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOffice.Models
{
    public class Staff:Person
    {
        public string StaffCode { get; set; }
        public ContractType ContractType { get; set; }

    }
}