using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModelDemo
{
    public class Tag
    {
        public int Id { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
