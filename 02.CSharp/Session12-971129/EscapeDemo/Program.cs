using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salaam,\tChetori?");
            Console.WriteLine("Salaam,\nChetori?");
            Console.WriteLine("Salaam \"John\",Chetori?");
            Console.WriteLine("Salaam \\John\\,Chetori?");
            Console.WriteLine(@"C:\MyFolder\SubFolder\MyFile.txt");
            Console.ReadKey();
        }
    }
}
