using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByValByRefDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            Console.WriteLine(a);
            ChangeInt(ref a);
            Console.WriteLine(a);
            Console.WriteLine("-------------");
            DateTime b = DateTime.Now;
            Console.WriteLine(b);
            ChangeDate(ref b);
            Console.WriteLine(b);
            Console.WriteLine("-------------");
            int[] c = new int[] { 10 };
            Console.WriteLine(c[0]);
            ChangeArray(ref c);
            Console.WriteLine(c[0]);
            Console.ReadKey();
        }

        static void ChangeInt(ref int x)
        {
            var y = 50;
            x = y;
        }

        static void ChangeDate(ref DateTime x)
        {
            x = x.AddDays(10);
        }

        static void ChangeArray(ref int[] x)
        {
            //x[0] = 50;
            int[] y = new int[] { 50 };
            x = y;
        }
    }
}
