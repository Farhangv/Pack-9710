using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num1 = int.Parse(input);
            input = Console.ReadLine();
            int num2 = Convert.ToInt32(input);

            Console.WriteLine(num1 + num2);

            Console.ReadKey();
        }
    }
}
