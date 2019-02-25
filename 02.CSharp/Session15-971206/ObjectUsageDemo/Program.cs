using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectUsageDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            p.name = "John";
            p.family = "Doe";
            p.birthDate = DateTime.Parse("1980/10/10");
            p.age = 38;
            Person k = new Person() {
                name = "Ross",
                family = "Geller",
                birthDate = DateTime.Parse("1990/10/10"),
                age = 28
            };

            Person[] people = new Person[] { p, k };

            string name1 = "C#";
            string name2 = "Java";

            string[] names = new string[] { name1, name2 };

            Console.WriteLine($"{p.name} {p.family} {p.birthDate} | {p.age} Years Old!");
            Console.ReadKey();

        }
    }
}
