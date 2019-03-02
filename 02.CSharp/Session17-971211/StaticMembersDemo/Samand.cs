using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembersDemo
{
    class Samand
    {
        public string PlateNumber { get; set; }
        public static string Manufacturer { get; set; }

        public override string ToString()
        {
            return $"{Samand.Manufacturer} : {this.PlateNumber}";
        }
    }
}
