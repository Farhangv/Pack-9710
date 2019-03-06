using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Salam");
            al.Add(123);
            al.Add(DateTime.Now);

            al.Remove(123);
            al.RemoveAt(1);

            al.Add(new Person() { Name = "John", Family = "Doe" });
            al.Add(new Person() { Name = "Sarah", Family = "Smith" });
            al.Add(new Person() { Name = "Chandler", Family = "Bing" });

            al.Remove(new Person() { Name = "Chandler", Family = "Bing" });

            Console.WriteLine(al.IndexOf(new Person() { Name = "Sarah", Family = "Smith" }));
            al.Contains("Salam");
            for (int i = 0; i < al.Count; i++)
            {
                //if(al[i] is string)
                //    Console.WriteLine(((string)al[i]).Contains('a'));

                Console.WriteLine(al[i]);
            }

            Console.ReadKey();
        }
    }
}
