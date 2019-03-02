using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDemo
{
    class MyClass
    {
        public MyClass()
        {
            MyClass.Count++;
        }
        public static int Count { get; set; }

        ~MyClass()
        {
            MyClass.Count--;
        }
    }
}
