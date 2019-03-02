using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDestructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parent p = new Parent("John", "Doe");
            //Parent p = new Parent();
            Child c = new Child("Sarah", "Smith");
            c = new Child("John", "Doe");

            GC.Collect();

            Console.ReadKey();
        }
    }
}
