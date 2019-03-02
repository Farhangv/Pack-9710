using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICalculatable c = new ICalculatable();
            ICalculatable[] calculatables = new ICalculatable[]
                {
                    new Employee() { BaseRate = 10000, WorkingHours = 160 },
                    new Product() { Cost = 2000000 },
                    new Service() { Price = 3000000 }
                };
            var sum = 0.0;
            for (int i = 0; i < calculatables.Length; i++)
            {
                Console.WriteLine($"{calculatables[i]:#,###.0}");
                sum += calculatables[i].GetAmount();
            }

            Console.WriteLine("----------------");
            Console.WriteLine($"{sum: #,###.0}");
            
            Console.ReadKey();
        }
    }
}
