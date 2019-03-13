using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace InsertDemo
{
    class BookDataAccess
    {
        private readonly string connectionString;
        private SqlConnection connection;
        public BookDataAccess(string _connectionString)
        {
            connectionString = _connectionString;
        }
        public void Insert(Book book)
        {
            using (this.connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO Book VALUES(@Title,@Author,@CreatedDate,@ModifiedDate)", connection))
                {
                    command.Parameters.Add(new SqlParameter("@Title", SqlDbType.NVarChar, 50));
                    command.Parameters.Add(new SqlParameter("@Author", SqlDbType.NVarChar, 50));
                    command.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime));
                    command.Parameters.Add(new SqlParameter("@ModifiedDate", SqlDbType.DateTime));
                    command.Parameters["@Title"].Value = book.Title;
                    command.Parameters["@Author"].Value = book.Author;
                    command.Parameters["@CreatedDate"].Value = book.CreatedDate;
                    command.Parameters["@ModifiedDate"].Value = book.ModifiedDate;
                    
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Book> GetAll()
        {
            List<Book> books = new List<Book>();
            using (this.connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Book", this.connection))
                {
                    command.Connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var book = new Book()
                        {
                            Id = int.Parse(reader["Id"].ToString()),
                            Title = reader[1].ToString(),
                            Author = reader["Author"].ToString(),
                            CreatedDate = (DateTime)reader["CreatedDate"],
                            ModifiedDate = (DateTime)reader["ModifiedDate"]
                        };
                        books.Add(book);
                    }
                }
            }
            return books;
        }
    }
}
