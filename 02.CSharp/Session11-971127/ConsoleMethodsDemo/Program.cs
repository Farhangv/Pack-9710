using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To My App");
            Console.Write("Your Name:");
            string name = Console.ReadLine();
            Console.Write("Your Family:");
            string family = Console.ReadLine();

            Console.WriteLine(
                    "Hello " + name + " " + family + " How Are You?"
                );
            Console.WriteLine("Hello {0} {1}, How Are You?",name,family);
            Console.WriteLine($"Hello {name} {family}, How Are You?");

            int number = 123456789;
            Console.WriteLine($"Number Is : {number:x}");

            Console.WriteLine("Goodbye");
            Console.ReadKey();
        }
    }
}
