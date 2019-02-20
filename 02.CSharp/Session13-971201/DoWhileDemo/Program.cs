using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            //while (i > 10)
            do
            {
                Console.WriteLine(i);
                i--;
            } while (i > 10);

            Console.ReadKey();
        }
    }
}
