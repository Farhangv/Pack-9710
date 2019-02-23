using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] actors = new
                string[] {
                    "John",
                    "Ross",
                    "Monica"
                };

            while (true)
            {
                Console.Clear();
                for (int i = 0; i < actors.Length; i++)
                {
                    Console.WriteLine(actors[i]);
                }
                Console.WriteLine("-----------------");
                Console.WriteLine("New Name:");
                var input = Console.ReadLine();
                AddToArray(ref actors, input);
            }
        }
        static void AddToArray(ref string[] names, string newName)
        {
            var newArray = new string[names.Length + 1];
            for (int i = 0; i < names.Length; i++)
            {
                newArray[i] = names[i];
            }
            newArray[newArray.Length - 1] = newName;
            names = newArray;
        }
    }
}
