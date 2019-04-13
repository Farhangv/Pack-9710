using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModelDemo
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}
