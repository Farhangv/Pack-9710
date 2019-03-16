using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    public class BookShopDbContext : DbContext
    {
        public BookShopDbContext()
            :base("BookShop")
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>()
                .Property(b => b.Title)
                .HasMaxLength(50);

            modelBuilder.Entity<Inventory>()
                .HasRequired(i => i.Book)
                .WithOptional(b => b.Inventory);
        }
    }
}
