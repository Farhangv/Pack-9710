using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //{
                Int32 num; //Decleration
                String name;
                Object obj;
            //}

            num = 10;
            name = "John";
            obj = new object();

            var anotherNum = 20;
            //anotherNum = "";
            //num = "Ross";

            Console.WriteLine(anotherNum.GetType());
            Console.WriteLine(num);
            Console.WriteLine(name);
            Console.WriteLine(obj);

            Console.ReadKey();
        }
    }
}
