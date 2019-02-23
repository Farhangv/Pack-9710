using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefValueTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;
            Console.WriteLine($"a:{a}, b:{b}");
            a = 20;
            Console.WriteLine($"a:{a}, b:{b}");
            Console.WriteLine("--------------");
            int[] c = new int[] { 10 };
            int[] d = c;
            Console.WriteLine($"c[0]:{c[0]}, d[0]:{d[0]}");
            c[0] = 20;
            Console.WriteLine($"c[0]:{c[0]}, d[0]:{d[0]}");
            Console.WriteLine("--------------");
            string e = "Salam";
            string f = e;
            Console.WriteLine($"e:{e}, f:{f}");
            e = "Hello";
            Console.WriteLine($"e:{e}, f:{f}");

            Console.ReadKey();
        }
    }
}
