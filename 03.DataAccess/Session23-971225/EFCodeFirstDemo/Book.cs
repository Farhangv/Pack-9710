using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    [Table("Book")]
    public class Book
    {
        public Book()
        {
            Authors = new List<Author>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        [Index(IsUnique = true), MaxLength(50)]
        public string ISBN { get; set; }

        public virtual Category Category { get; set; }
        public int? CategoryId { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}
