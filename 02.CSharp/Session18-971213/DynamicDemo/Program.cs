using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic d = new ExpandoObject();
            d.Name = "John";
            d.Family = "Doe";
            //d.Name = 10;
            Console.WriteLine(d.Name);
            Console.WriteLine(d.Family);
            //Console.WriteLine(d.Age);
            Console.ReadKey();

        }
    }
}
