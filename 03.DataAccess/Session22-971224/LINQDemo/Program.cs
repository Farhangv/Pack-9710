using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] {
            //    "C#", "Java", "C++", "Python", "JavaScript", "PHP", "VBScript", "TypeScript", "XML", "HTML"
            //};

            //var selectedName = from n in names
            //                   where n.Contains("Script") //n.EndsWith("ML")
            //                   orderby n descending
            //                   select n.Length;

            //foreach (var name in selectedName)
            //{
            //    Console.WriteLine(name);
            //}

            Product[] products = new Product[]
                {
                    new Product() { Id = 1, Name = "KeyBoard", ListPrice = 100000 },
                    new Product() { Id = 2, Name = "Laptop", ListPrice = 20000000 },
                    new Product() { Id = 3, Name = "Monitor", ListPrice = 500000 },
                };

            //LINQ
            //var selectedProducts = from p in products
            //                       where p.ListPrice > 200000
            //                       select new { Name = p.Name, ListPrice = p.ListPrice };

            //LINQ Extension Methods
            var selectedProducts = products.Where(p => p.ListPrice > 200000)
                                    .OrderBy(p => p.Name)
                                    .Select(p => new { Name = p.Name, ListPrice = p.ListPrice });

            foreach (var p in selectedProducts)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
        }

    }
}
