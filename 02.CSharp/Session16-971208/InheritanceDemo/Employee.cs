using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Employee:Person
    {
        public int BaseRate { get; set; }
        public int WorkingHours { get; set; }
        public double Tax { get; set; }

        public override double GetBalance()
        {
            return (BaseRate * WorkingHours * (1 - Tax)) * -1;
        }
    }
}
