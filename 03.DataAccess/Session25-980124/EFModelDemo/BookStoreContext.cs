namespace EFModelDemo
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BookStoreContext : DbContext
    {
        public BookStoreContext()
            : base("BookStoreContext")
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }

}