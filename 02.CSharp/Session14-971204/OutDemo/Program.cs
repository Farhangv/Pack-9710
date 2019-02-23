using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 14, 15, 3, 5, 87, 96, 42, 12, 32, 85, 65, 45, 16 };
            //int max, min;
            //double avg;
            var sum = Sum(nums, out int max, out int min, out double avg);
            Console.WriteLine(sum);
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(avg);

            Console.ReadKey();
        }

        static int Sum(int[] numbers, out int max, out int min, out double average)
        {
            var sum = 0;
            max = numbers[0];
            min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                if (numbers[i] > max)
                    max = numbers[i];
                if (numbers[i] < min)
                    min = numbers[i];
            }
            average = sum / numbers.Length;
            return sum;
        }
    }
}
