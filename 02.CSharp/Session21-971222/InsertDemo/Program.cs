using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseHelper.SetupDatabase();
            BookDataAccess dataAccess = new BookDataAccess(ConfigurationManager.ConnectionStrings["BookStore"].ConnectionString);

            while (true)
            {
                Console.Clear();
                var books = dataAccess.GetAll();
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
                Console.WriteLine("---------------------");

                Book newBook = new Book();
                Console.Write("Title: ");
                newBook.Title = Console.ReadLine();
                Console.Write("Author: ");
                newBook.Author = Console.ReadLine();
                newBook.CreatedDate = DateTime.Now;
                newBook.ModifiedDate = DateTime.Now;
                dataAccess.Insert(newBook);

            }

        }


    }
}
