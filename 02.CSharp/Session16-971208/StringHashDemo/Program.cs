using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHashDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("abc".GetHashCode());
            Console.WriteLine("abc".GetHashCode());
            Console.WriteLine(123.GetHashCode());
            Console.ReadKey();
        }
    }
}
