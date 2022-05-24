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

        public static string GetUsnAndName(string UserId)
        {
            string UsnAndName = "";
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string sqlCommand = "SELECT * FROM users WHERE ID='" + UserId + "' LIMIT 1";

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                UsnAndName = reader["USN"].ToString() + " - " + reader["Name"].ToString();
            }

            dbConnection.Close();
            return UsnAndName;
        }

        public static string GetFieldValue(string UserId, string Field)
        {
            string FieldValue = "";
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string sqlCommand = "SELECT * FROM users WHERE ID='" + UserId + "' LIMIT 1";

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();

                FieldValue = reader[Field].ToString();
            }

            dbConnection.Close();
            return FieldValue;
        }

        public static bool ExistingUsn(string Usn, string UserId = "")
        {
            bool Exist = false;
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string sqlCommand = "SELECT * FROM users WHERE USN='" + Usn + "'";
            
            if (!UserId.Equals(""))
            {
                sqlCommand += " AND ID != '" + UserId + "'";
            }
            sqlCommand += " LIMIT 1";

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                Exist = true;
            }

            dbConnection.Close();
            return Exist;
        }
    }

}
