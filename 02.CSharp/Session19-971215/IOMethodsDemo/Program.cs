using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = Directory.CreateDirectory(@"MyFolder");
            Console.WriteLine(d.FullName);
            //Directory.CreateDirectory("D:\\MyAbsoluteFolder");
            //Directory.Delete(@"MyFolder",true);
            Directory.SetLastWriteTime("D:\\MyAbsoluteFolder", DateTime.Now);
            Console.WriteLine(Directory.Exists("D:\\MyAbsoluteFolder"));

            //var file = File.Create("Sample.txt");
            //StreamWriter sw = new StreamWriter(file);
            //sw.Close();

            using (var writer = File.CreateText("Sample.txt"))
            {
                writer.WriteLine("Hello");
            }

            //File.Copy("Sample.txt", "D:\\Test.txt");
            //File.Replace("D:\\Test.txt", "Sample.txt", "Sample_Backup.txt");

            Console.ReadKey();
        }
    }
}
