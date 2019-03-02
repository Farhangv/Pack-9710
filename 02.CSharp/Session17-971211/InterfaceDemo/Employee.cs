using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Employee : ICalculatable
    {
        public int WorkingHours { get; set; }
        public double BaseRate { get; set; }
        public double GetAmount()
        {
            return WorkingHours * BaseRate * -1;
        }
        public override string ToString()
        {
            return this.GetAmount().ToString();
        }
    }
}
