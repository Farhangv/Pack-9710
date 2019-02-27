using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ParentChildDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            object o1 = new Person();//Boxing
            object o2 = "Hello";
            object o3 = 12;
            object o4 = true;
            object o5 = DateTime.Now;
            object o6 = new string[] { "" };

            o2 = 12345;

            Console.WriteLine(o2);

            //Person p1 = new object();

            Stream s1 = new NetworkStream(null);//Upcasting
            Stream s2 = new FileStream(null, FileAccess.Read);
            Stream s3 = new MemoryStream();

            Console.ReadKey();


        }
    }
}
