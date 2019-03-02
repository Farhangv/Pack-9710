using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Samand s = new Samand();
            s.PlateNumber = "IR4471BB456";
            Samand s2 = new Samand();
            s2.PlateNumber = "IR2241DD741";
            //s.Manufacturer = "IranKhodro";
            //s2.Manufacturer = "IranKhodro";
            //Samand.Manufacturer = "IranKhodro";

            //Program.WriteHello();
            Program p = new Program();
            p.WriteHello();

            Console.WriteLine();
            //Console c = new Console();
            //Math.Sin()
            
        }

        public void WriteHello()
        {
            Console.WriteLine("Hello");
        }

        public int Factotial(int number)
        {
            var result = number;
            if(number > 1)
                result *= Factotial(--number);
            return result;
        }
    }
}
