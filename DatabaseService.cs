using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EDP_Project
{
    public static class DatabaseService
    {
        private static readonly string ConnectionString = "Server=localhost;Database=libsys;Uid=root;Pwd=mysqlkira;";

        public static MySqlConnection GetConnection()
        {
            try
            {
                var connection = new MySqlConnection(ConnectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to establish a database connection.", ex);
            }
        }
    }
}