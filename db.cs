using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advertising
{
    static class db
    {
        public static string ConnectionString;
        static db()
        {
            ConnectionString= ConfigurationManager.ConnectionStrings["Mysqlconnection"].ConnectionString;
        }
        /*
        MySqlConnection connection = new MySqlConnection("server= localhost; port=3307; username = root; password=root; database=adverisiting; SSLMode=none");
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
              connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        */
    }
}
