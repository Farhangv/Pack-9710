using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
                {
                    new Student() { Name = "John", Family = "Doe", Score = 60 },
                    new Student() { Name = "David", Family = "Doe", Score = 30 },
                    new Student() { Name = "Monica", Family = "Geller", Score = 90 },
                    new Student() { Name = "Sheldon", Family = "Cooper", Score = 70 }
                };
            Array.Sort(students);
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
            Console.ReadKey();
        }
    }
}
