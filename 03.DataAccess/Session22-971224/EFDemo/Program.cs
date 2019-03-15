using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AWEntities context = new AWEntities();
            var people = context.People
                .Where(p => p.PersonType == "EM")
                .ToList();
            foreach (var p in people)
            {
                Console.WriteLine($"{p.BusinessEntityID}.{p.FirstName} {p.LastName}({p.PersonType}) - {p.Employee.JobTitle}");
            }
            Console.ReadKey();
        }
    }
}
