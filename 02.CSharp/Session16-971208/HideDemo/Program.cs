using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Child();
            p.VirtualMethod();
            p.NormalMethod();

            Child c = new Child();
            c.VirtualMethod();
            c.NormalMethod();

            Console.ReadKey();
        }
    }
}
