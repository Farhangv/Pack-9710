using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("");
            WebClient client = new WebClient();
            FileStream fs = new FileStream("", FileMode.Open);
            //var result = fs.BeginRead();
            //...
            //fs.EndRead(result);
        }
    }
}
