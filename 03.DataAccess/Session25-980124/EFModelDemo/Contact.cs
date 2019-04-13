using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModelDemo
{
    public class Contact
    {
        public int Id { get; set; }
        [Index(IsUnique = true)]
        public string Value { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
    }
}
