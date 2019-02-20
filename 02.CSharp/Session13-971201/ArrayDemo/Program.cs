using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[5];
            //names[0] = "C#";
            //names[1] = "Java";
            //names[2] = "PHP";
            //names[3] = "Python";
            //names[4] = "JavaScript";

            var names = new string[] {
                "C#","Java","Perl","Python","Ruby","PHP","JavaScript"
            };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadKey();
        }
    }
}
