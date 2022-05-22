using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace LibrarySystem.Model
{
    class User
    {
        

        public static MySqlDataReader Authenticate(string Usn, string pwd)
        {
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string sqlCommand = "SELECT * FROM users WHERE USN='" + Usn + "' AND Password='" + pwd + "'";

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            dbConnection.Close();
            return reader;
        }
    }

}
