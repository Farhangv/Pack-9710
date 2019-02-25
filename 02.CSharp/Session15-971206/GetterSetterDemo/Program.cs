using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[10];
            for (int i = 0; i < people.Length; i++)
            {
                Console.Clear();
                for (int j = 0; j < people.Length; j++)
                {
                    if(people[j] != null)
                        Console.WriteLine($"{people[j].GetFullName()} - {people[j].GetBirthDate()} | {people[j].GetAge()}");
                }
                Console.WriteLine("-------------------");
                Person p = new Person();
                Console.WriteLine("Enter Full Name:");
                //p.fullname = Console.ReadLine();
                p.SetFullName(Console.ReadLine());
                Console.WriteLine("BirthDate:");
                //p.birthDate = DateTime.Parse(Console.ReadLine());
                //p.SetBirthDate(DateTime.Parse(Console.ReadLine()));
                p.SetBirthDate(Console.ReadLine());
                //Console.WriteLine("Age:");
                //p.age = int.Parse(Console.ReadLine());
                people[i] = p;
            }

            Console.ReadKey();
        }
    }
}
