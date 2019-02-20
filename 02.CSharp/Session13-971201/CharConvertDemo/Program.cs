using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharConvertDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToChar(97));
            Console.WriteLine((char)65);
            Random r = new Random();
            Console.WriteLine((char)r.Next(65,91));
            Console.ReadKey();
        }
    }
}
