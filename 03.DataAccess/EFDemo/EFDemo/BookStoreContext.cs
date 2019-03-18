namespace EFDemo
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BookStoreContext : DbContext
    {
        public BookStoreContext()
            : base("BookStoreContext")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<BookStoreContext>());
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

}