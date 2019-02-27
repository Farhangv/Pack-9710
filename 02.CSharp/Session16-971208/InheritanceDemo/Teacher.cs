using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Teacher:Person
    {
        public int BaseRate { get; set; }
        public int TeachingHours { get; set; }

        public override double GetBalance()
        {
            return BaseRate * TeachingHours * -1;
        }
    }
}
