using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            Console.WriteLine(text.Length);

            Console.WriteLine(text.Substring(0,1));
            Console.WriteLine(text[3]);
            Console.ReadLine();
        }
    }
}
