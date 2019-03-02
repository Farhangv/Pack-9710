using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]
                {
                    "C#", "Java", "PHP", "Python", "C++"
                };
            foreach (string name in names)
            {
                Console.WriteLine(name);
                //name = "Perl";
            }
            Console.ReadKey();
        }
    }
}
