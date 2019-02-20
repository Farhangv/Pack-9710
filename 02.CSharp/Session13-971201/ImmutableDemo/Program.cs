using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmutableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            string x = "John";

            name = name + "Added Text";

            const int a = 10;

            Console.WriteLine(ReferenceEquals(name,x));
            Console.ReadKey();
        }
    }
}
