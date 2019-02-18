using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarInitializationDemo
{
    class Program
    {
        static int anotherNum;
        static void Main(string[] args)
        {
            //Nullable<int> score = null; //Value
            int? score = null;
            string name = null; //Ref

            //Console.WriteLine(num);
            Console.WriteLine(anotherNum);
            Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}
