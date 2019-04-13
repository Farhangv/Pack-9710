using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModelDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.Tags = new List<Tag>();
            b.Tags.Add(new Tag());
        }
    }
}
