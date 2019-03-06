using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }

        public override string ToString()
        {
            return $"{Name} {Family}";
        }

        public override int GetHashCode()
        {
            return $"{Name}{Family}".GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return this.GetHashCode() == obj.GetHashCode();
        }
    }
}
