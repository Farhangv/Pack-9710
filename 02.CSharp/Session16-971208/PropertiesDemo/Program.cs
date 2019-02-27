using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FullName = "John";
            p.BirthDate = DateTime.Parse("2000/10/10");
            Console.WriteLine(p.Age);
            Console.ReadKey();
        }
    }
}
