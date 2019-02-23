using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("       a   bc        ".Trim() + "xyz");
            Console.WriteLine("Hello, How Are You?".Substring(5,4));
            Console.WriteLine("Hello, How Are You?"[5]);
            Console.WriteLine("Hello, How Are You?".ToLower());
            Console.WriteLine("Hello, How Are You?".ToUpper());
            Console.WriteLine("Hello, How Are You?".Contains("You"));
            Console.WriteLine("Hello, How Are You?".Replace("How", "Where"));
            var parts = "1397/12/04".Split('/');
            Console.WriteLine(parts[0]);
            Console.WriteLine(parts[1]);
            Console.WriteLine(parts[2]);
            Console.WriteLine("Hello, How Are You?  You".IndexOf("You"));
            Console.WriteLine("Hello, How Are You?".IndexOf("Me"));
            Console.WriteLine("Hello, How Are You?".IndexOf(','));
            Console.WriteLine("Hello, How Are You?  You".LastIndexOf("You"));
            Console.WriteLine("1397/12/04".Replace("/", "-"));
            Console.ReadKey();
            
        }
    }
}
