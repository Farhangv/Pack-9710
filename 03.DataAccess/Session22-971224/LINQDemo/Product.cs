using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ListPrice { get; set; }

        public override string ToString()
        {
            return $"{Id}.{Name}: {ListPrice}";
        }
    }
}
