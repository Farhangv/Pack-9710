using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 0;
            //throw new Exception();
            try
            {
                Console.WriteLine(int.Parse("abc") / b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadKey();
        }
    }
}
