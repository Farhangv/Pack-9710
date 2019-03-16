using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertDemo
{
    class DatabaseHelper
    {

        public static void SetupDatabase()
        {
            CreateDatabase();
            CreateTables();
        }
        public static void CreateDatabase()
        {
            ExecuteNonQueryFromFile("DatabaseSetup.sql", "master");
        }

        public static void CreateTables()
        {
            ExecuteNonQueryFromFile("CreateTables.sql", "BookStore");
        }

        protected static void ExecuteNonQueryFromFile(string _fileName, string _connectionStringName)
        {
            var connectionString = ConfigurationManager.ConnectionStrings[_connectionStringName].ConnectionString;
            var script = string.Empty;
            using (StreamReader sr = new StreamReader(_fileName))
            {
                script = sr.ReadToEnd();
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(script, connection))
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
