using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDestructorDemo
{
    class Child:Parent
    {
        public Child(string _n, string _f):base(_n , _f)
        {
            Console.WriteLine("From Child");
        }

        ~Child()
        {
            Console.WriteLine("Child Destructed");
        }
    }
}
