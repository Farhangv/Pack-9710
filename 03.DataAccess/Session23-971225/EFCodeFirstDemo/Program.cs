using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace EFCodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BookShopDbContext context = new BookShopDbContext();
            /*
            //var category = context.Categories
            //    .Where(c => c.Name == "Programming").FirstOrDefault();
            //var category = context.Categories.Find(1);
            var book = new Book()
            {
                Title = "Advanced CSS3",
                //Author = "Sarah Doe",
                ISBN = "773-442179-7819",
                //Category = category,
                //Category_Id = 1
                CategoryId = 1,
                Authors = new List<Author>()
                 {
                     new Author() { FullName = "Sheldon Cooper" },
                     new Author() { FullName = "Ned Stark" }
                 },
                Inventory = new Inventory() { Location = "LocABC", Quantity = 40 }
            };

            context.Books.Add(book);
            
            context.SaveChanges();
            */
            //var books = context.Books.Include("Authors").ToList();
            var books = context.Books.ToList();

            foreach (var b in books)
            {
                Console.WriteLine($"{b.Title}({string.Join(",", b.Authors?.Select(a => a.FullName).ToList())})");
            }

            Console.ReadKey();
        }
    }
}
