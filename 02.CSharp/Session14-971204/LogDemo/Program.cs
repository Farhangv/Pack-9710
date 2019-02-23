using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number:");
            if(int.TryParse(Console.ReadLine(), out int num))
                Console.WriteLine(Math.Log10(num));
            else
                Console.WriteLine("Incorrect Format!");
            Console.ReadKey();
        }
    }
}
