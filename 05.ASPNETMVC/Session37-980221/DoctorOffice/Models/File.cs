using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOffice.Models
{
    public class File
    {
        public int Id { get; set; }
        public string OriginalFileName { get; set; }
        public string Extension { get; set; }
        public int Size { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public virtual Patient Patient { get; set; }
        public int PatientId { get; set; }
    }
}