using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Username:");
            var username = Console.ReadLine().ToLower();
            Console.Write("Password:");
            var password = Console.ReadLine();

            if(username == "admin" && password == "Pa$$w0rd")
                Console.WriteLine("You are logged in!");
            else
                Console.WriteLine("Login Failed!");

            Console.ReadKey();
        }
    }
}
