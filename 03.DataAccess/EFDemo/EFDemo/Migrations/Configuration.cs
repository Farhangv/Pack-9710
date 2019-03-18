namespace EFDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFDemo.BookStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EFDemo.BookStoreContext";
        }

        protected override void Seed(EFDemo.BookStoreContext context)
        {
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Categories.AddOrUpdate(c => c.Name,
                new Category() { Name = "تاریخی" },
                new Category() { Name = "آموزشی" },
                new Category() { Name = "داستان" },
                new Category() { Name = "ادبی" },
                new Category() { Name = "کودک" }
                );
        }
    }
}
