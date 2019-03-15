using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDbFirstCRUDDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BookStoreEntities context = new BookStoreEntities();
            /*
             * Create
             */

            //Book book = new Book()
            //{
            //    Title = "Pro Python",
            //    Author = "Sheldon Cooper",
            //    CreatedDate = DateTime.Now,
            //    ModifiedDate = DateTime.Now
            //};

            //context.Books.Add(book);
            //context.SaveChanges();

            /*
             * Edit
             */

            //var book = context.Books.Find(1);
            //book.Title = "Illustrated C#";
            //book.ModifiedDate = DateTime.Now;
            //context.SaveChanges();


            /*
             * Delete
             */

            var book = context.Books.Find(3);
            context.Books.Remove(book);
            context.SaveChanges();

        }
    }
}
