using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    public class Inventory
    {
        [Key]
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public string Location { get; set; }
    }
}
