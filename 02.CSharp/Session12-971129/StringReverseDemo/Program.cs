using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter you text:");
            var text = Console.ReadLine();
            int i = text.Length - 1;
            while (i >= 0)
            {
                Console.Write(text[i--]);
            }
            Console.ReadKey();
        }
    }
}
