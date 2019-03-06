using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("First");
            s.Push("Second");
            s.Push("Third");

            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            Console.ReadKey();
        }
    }
}
