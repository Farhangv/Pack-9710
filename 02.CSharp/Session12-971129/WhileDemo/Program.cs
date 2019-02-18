using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            while (i > 0)
            {
                Console.Clear();
                Console.WriteLine(i--);
                Console.Beep(5000, 500);
                Thread.Sleep(500);
                //i = i - 1;
                //i -= 1;
                //i--;
            }

            Console.ReadKey();
        }
    }
}
