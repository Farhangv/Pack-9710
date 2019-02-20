using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            Random r = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(1, 201);
            }
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadKey();
        }
    }
}
