using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModelDemo
{
    public class Book
    {
        public Book()
        {
            IsTranslated = false;
            Tags = new List<Tag>();
        }
        public int Id { get; set; }
        public virtual Category Category { get; set; }
        public int? CategoryId { get; set; }

        public ICollection<Tag> Tags { get; set; }

        public bool IsTranslated { get; set; }
        public virtual Book OriginalBook { get; set; }
        public int? OriginalBookId { get; set; }

    }
}
