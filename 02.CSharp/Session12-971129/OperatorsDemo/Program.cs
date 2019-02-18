using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            //a = a + 1;
            a += 1;//11
            a -= 1;//10
            a *= 2;//20
            a /= 4;//5
            a %= 2;//1
            //a = a % 2;

            Console.WriteLine(a++);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
