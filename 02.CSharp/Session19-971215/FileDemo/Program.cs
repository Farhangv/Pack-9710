using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (StreamWriter sw = new StreamWriter("MyFile.txt"))
            //{
            //    //sw.AutoFlush = true;
            //    for (string input = string.Empty; input != "exit";)
            //    {
            //        input = Console.ReadLine();
            //        sw.WriteLine(input);
            //        //sw.Flush();
            //    }
            //} //sw.Close();

            using (StreamReader sr = new StreamReader("MyFile.txt"))
            {
                //Console.WriteLine((char)sr.Read());
                //Console.WriteLine((char)sr.Read());
                //Console.WriteLine((char)sr.Read());
                //Console.WriteLine((char)sr.Read());
                //Console.WriteLine((char)sr.Read());
                //while (sr.Peek() != -1)
                //{
                //    Console.Write((char)sr.Read());
                //}

                //Console.WriteLine(sr.ReadLine());
                //Console.WriteLine(sr.ReadLine());

                Console.WriteLine(sr.ReadToEnd());
            }

            Console.ReadKey();
        }
    }
}
