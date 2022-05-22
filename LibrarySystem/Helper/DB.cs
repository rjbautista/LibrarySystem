using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace LibrarySystem.Helper
{
    class DB
    {
        public static void ExecuteNonQuery(string SqlCommand)
        {
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            dbConnection.Open();
            MySqlCommand command = new MySqlCommand(SqlCommand, dbConnection);
            command.ExecuteNonQuery();
            dbConnection.Close();
        }
    }
}
