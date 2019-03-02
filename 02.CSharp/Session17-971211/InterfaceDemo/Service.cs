using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Service : ICalculatable, IInvoicable
    {
        public double Price { get; set; }
        public double GetAmount()
        {
            return this.Price;
        }

        public string GetName()
        {
            return "Service Name";
        }

        public override string ToString()
        {
            return this.GetAmount().ToString();
        }
    }
}
