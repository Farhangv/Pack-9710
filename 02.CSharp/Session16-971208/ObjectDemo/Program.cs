using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person()
            {
                Name = "John",
                Family = "Doe"
            };
            Person p2 = new Person()
            {
                Name = "John",
                Family = "Doe"
            };
            //Object o = new Object();
            Console.WriteLine(p.GetType());
            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(p.ToString());
            Console.WriteLine(p.Equals(123)/*Boxing*/);
            Console.ReadKey();
        }
    }
}
