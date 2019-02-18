using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter you score [0-100] :");
            var score = int.Parse(Console.ReadLine());

            //if (score >= 10)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Passed!");
            //}
            //else
            //    Console.WriteLine("Failed!");

            if (score >= 0 && score <= 100)
            {
                if (score >= 90)
                    Console.WriteLine("A+");
                else if (score >= 80)
                    Console.WriteLine("A");
                else if (score >= 70)
                    Console.WriteLine("B+");
                else
                    Console.WriteLine("Failed!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Score Entered!");
            }
            Console.ReadKey();
        }
    }
}
