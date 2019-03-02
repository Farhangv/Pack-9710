using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Product : ICalculatable, IInvoicable
    {
        public double Cost { get; set; }
        public double GetAmount()
        {
            return this.Cost * -1;
        }

        public string GetName()
        {
            return "Product Name";
        }

        public override string ToString()
        {
            return this.GetAmount().ToString();
        }
    }
}
