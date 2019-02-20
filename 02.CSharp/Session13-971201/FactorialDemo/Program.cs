using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number:");
            int result = 1;
            for (int i = int.Parse(Console.ReadLine()); i > 1; i--)
            {
                result *= i;
            }
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
