using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<string,int> mc = new MyClass<string,int>();
            mc.MyMethod("");
        }
    }
}
