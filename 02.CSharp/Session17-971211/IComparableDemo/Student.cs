using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    class Student:IComparable
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public double Score { get; set; }

        public int CompareTo(object obj)
        {
            var other = obj as Student;
            if (other != null)
            {
                var familyCompare = this.Family.CompareTo(other.Family);
                if (familyCompare == 0)
                    return this.Name.CompareTo(other.Name);
                return familyCompare;
            }
            throw new InvalidOperationException();
        }

        public override string ToString()
        {
            return $"{Name}\t\t{Family}\t\t{Score:##.00}";
        }
    }
}
