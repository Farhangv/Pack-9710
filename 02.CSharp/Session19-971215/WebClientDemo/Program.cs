using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebClientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            //client.BaseAddress = "http://irna.ir";
            var content = Encoding.UTF8.GetString(client.DownloadData("http://irna.ir"));

            using (StreamWriter sw = new StreamWriter("irna.txt", false))
            {
                sw.WriteLine(content);
            }

        }
    }
}
