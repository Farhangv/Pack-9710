using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    [Table("Book", Schema = "Books")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 5), Index(IsUnique = true), Required]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        [Column("CoverImage")]
        public byte[] Cover { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public DateTime CreatedDate { get; set; }
        [NotMapped]
        public string PersianCreatedDate {
            get {
                PersianCalendar pc = new PersianCalendar();
                return $"{pc.GetYear(this.CreatedDate)}" +
                    $"/{pc.GetMonth(this.CreatedDate)}" +
                    $"/{pc.GetDayOfMonth(this.CreatedDate)}";
            }

        }
        public DateTime ModifiedDate { get; set; }
    }
}
