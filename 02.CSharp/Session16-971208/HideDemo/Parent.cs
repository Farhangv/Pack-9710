using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideDemo
{
    class Parent
    {
        public virtual void VirtualMethod()
        {
            Console.WriteLine("From Parent");
        }
        public void NormalMethod()
        {
            Console.WriteLine("From Parent");
        }
    }
}
