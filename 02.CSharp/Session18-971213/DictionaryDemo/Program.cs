using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            SortedDictionary<int, string> dictionary = new SortedDictionary<int, string>();
            dictionary.Add(123, "Text Value 1");
            dictionary.Add(452, "Text Value 2");
            dictionary.Add(111, "Text Value 3");
            
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.ReadKey();
        }
    }
}
