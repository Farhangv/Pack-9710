using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertDemo
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public override string ToString()
        {
            return $"{this.Id}.{this.Title}\t{this.Author}\t{this.CreatedDate:yyyy/MM/dd}";
        }
    }
}
