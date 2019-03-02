using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDestructorDemo
{
    class Parent
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public Parent(string _name, string _family)
        {
            Console.WriteLine("From Parent");
            Name = _name;
            Family = _family;
        }
        //public Parent()
        //{
        //    Console.WriteLine("From Parent");
        //}
    }
}
