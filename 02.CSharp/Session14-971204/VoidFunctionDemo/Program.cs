using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidFunctionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = Sum(10, 20);
            Console.WriteLine(result);
            PrintSum(10, 20);
            Console.ReadKey();
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void PrintSum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
