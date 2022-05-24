using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace LibrarySystem.Model
{
    class Book
    {
        public static int GetActiveBookCountByHeaderId(string BookHeaderId)
        {
            int count = 0;
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string sqlCommand = "SELECT COUNT(ID) AS ActiveBookCount FROM bookdetails WHERE Status = 'active' AND IsAvailable = 1 AND BookHeaderId = '" + BookHeaderId + "'";

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                count = int.Parse(reader["ActiveBookCount"].ToString());
            }

            dbConnection.Close();
            return count;
        }

        public static int GetTotalBookCountByHeaderId(string BookHeaderId)
        {
            int count = 0;
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string sqlCommand = "SELECT COUNT(ID) AS BookCount FROM bookdetails WHERE BookHeaderId = '" + BookHeaderId + "'";

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                count = int.Parse(reader["BookCount"].ToString());
            }

            dbConnection.Close();
            return count;
        }

        public static void UpdateBookCount(string BookHeaderId)
        {
            // update book header count
            int TotalActiveBook = Model.Book.GetActiveBookCountByHeaderId(BookHeaderId);
            int TotalBook = Model.Book.GetTotalBookCountByHeaderId(BookHeaderId);
            string sqlCommand = "UPDATE bookheaders SET AvailableQty=" + TotalActiveBook + ", TotalQty=" + TotalBook + " WHERE ID=" + BookHeaderId;
            Helper.DB.ExecuteNonQuery(sqlCommand);
        }
    }
}
