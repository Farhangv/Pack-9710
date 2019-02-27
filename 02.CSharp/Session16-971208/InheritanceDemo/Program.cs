using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            Person[] people = new Person[]
                {
                    new Student() { Name = "John", Family = "Doe",
                        Courses = new Course[] {
                            new Course() { Title = "C#", Tuition = 2000000 },
                            new Course() { Title = "SQL", Tuition = 1000000 },
                            new Course() { Title = "ADO.NET", Tuition = 500000 }
                        }
                    },
                    new Student() { Name = "David", Family = "Doe",
                        Courses = new Course[] {
                            new Course() { Title = "PHP", Tuition = 1000000 },
                            new Course() { Title = "MySQL", Tuition = 1000000 },
                            new Course() { Title = "Laravel", Tuition = 2000000 }
                        }
                    },
                    new Employee() { Name = "Monica", Family = "Geller", BaseRate = 10000, Tax = 0.09, WorkingHours = 160 },
                    new SalesEmployee() { Name = "Rachel", Family = "Green", BaseRate = 20000, Tax = 0.1, ComissionPct = 0.05, WorkingHours = 150, TotalSales = 25000000 },
                    new Teacher() { Name = "Sheldon", Family = "Cooper", BaseRate = 25000, TeachingHours = 100 }
                };

            double totalBalance = 0;
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i].ToString());
                totalBalance += people[i].GetBalance();
            }
            Console.WriteLine($"\t\t\t\t|Total: {totalBalance:#,###}");
            Console.ReadKey();
        }
    }
}
