using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 10,52,45,36,96,75,85,95,63,14,52 };
            var m = Max(nums); //Invocation
            var m2 = Max(50, 20, 70);
            Console.WriteLine($"Max: {m}");
            Console.WriteLine(m2);
            //Console.WriteLine("");
            Console.ReadKey();
        }
        //Decleration - Definition
        static int Max(int[] numbers)
        {
            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > result)
                    result = numbers[i];
            }
            return result;
        }

        static int Max(int x, int y, int z)
        {
            int[] nums = new int[] { x, y, z };
            return Max(nums);
        }
    }
}
