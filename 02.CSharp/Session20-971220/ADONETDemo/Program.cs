using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ADONETDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cn = ConfigurationManager.ConnectionStrings["AW2016"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(cn))
            {
                SqlCommand command = new SqlCommand("EXEC GetAllProducts", connection);
                //connection.Open();
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["ProductId"]}\t{reader["Name"]}\t{reader["ListPrice"]}");
                }
            }//command.Connection.Close();

            Console.ReadKey();
        }
    }

}
