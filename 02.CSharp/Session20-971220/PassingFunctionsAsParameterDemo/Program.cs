using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingFunctionsAsParameterDemo
{
    public delegate bool Filter(int number);
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 41, 52, 12, 3, 75, 94, 31, 24, 62, 46 };

            //WriteFilteredNumbers(numbers,OddFilter);
            //WriteFilteredNumbers(numbers, EvenFilter);

            //WriteFilteredNumbers(numbers, 
            //        (x) =>
            //        {
            //            return x % 2 == 0;
            //        }
            //    );

            WriteFilteredNumbers(numbers, x => x % 2 == 0);

            Console.ReadKey();
        }

        static void WriteFilteredNumbers(int[] numbers, Filter filter)
        {
            foreach (var number in numbers)
            {
                if(filter(number))
                    Console.WriteLine(number);
            }
        }

        static bool OddFilter(int number)
        {
            return number % 2 != 0;
        }

        static bool EvenFilter(int number)
        {
            return number % 2 == 0;
        }
    }
}
