using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate void MathOperation(int[] numbers);
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 41,52,12,3,75,94,31,24,62,46 };

            MathOperation operations = new MathOperation(Sum);
            operations += Max;
            operations += Min;
            operations += (x) =>
            {
                var sum = 0;
                foreach (var num in x)
                {
                    sum += num;
                }
                Console.WriteLine(sum / x.Length);
            };

            operations(numbers);

            Console.ReadKey();
        }

        static void Sum(int[] _nums)
        {
            var sum = 0;
            foreach (var num in _nums)
            {
                sum += num;
            }
            Console.WriteLine($"Sum: {sum}");
        }

        static void Max(int[] _nums)
        {
            var max = _nums[0];
            for (int i = 1; i < _nums.Length; i++)
            {
                if (_nums[i] > max)
                    max = _nums[i];
            }
            Console.WriteLine($"Max: {max}");
        }
        static void Min(int[] _nums)
        {
            var min = _nums[0];
            for (int i = 1; i < _nums.Length; i++)
            {
                if (_nums[i] < min)
                    min = _nums[i];
            }
            Console.WriteLine($"Min: {min}");
        }
    }
}
