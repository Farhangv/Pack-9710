using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueRandomArrayDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] domain = new int[100];
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < domain.Length; i++)
            {
                domain[i] = i + 100;
            }
            Random r = new Random();
            int[] randomNumbers = new int[60];
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                var randomIndex = r.Next(0, domain.Length - i);
                randomNumbers[i] = domain[randomIndex];
                domain[randomIndex] = domain[domain.Length - 1 - i];
            }
            sw.Stop();
            Array.Sort(randomNumbers);
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                Console.WriteLine(randomNumbers[i]);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
    }
}
