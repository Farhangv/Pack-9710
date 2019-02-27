using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class SalesEmployee:Employee
    {
        public int TotalSales { get; set; }
        public double ComissionPct { get; set; }
        public override double GetBalance()
        {
            return base.GetBalance() + (TotalSales * ComissionPct * -1);
        }
    }
}
