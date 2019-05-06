namespace ProductManagerApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ProductManagerDbContext : DbContext
    {
        public ProductManagerDbContext()
            : base("ProductManagerDbContext")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}