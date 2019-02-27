using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideDemo
{
    class Child:Parent
    {
        public override void VirtualMethod()
        {
            Console.WriteLine("From Child");
        }
        public new void NormalMethod()
        {
            Console.WriteLine("From Child");
        }
    }
}
