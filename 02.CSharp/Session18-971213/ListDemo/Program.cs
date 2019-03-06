using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("C#");
            //names.Add(123);

            List<Person> people = new List<Person>();
            people.Add(new Person());

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

            people[1] = new Person();
            people.Add(new Person());
            people.Insert(1, new Person());
            people.Remove(new Person());
        }
    }
}
