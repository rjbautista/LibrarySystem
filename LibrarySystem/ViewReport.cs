using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace LibrarySystem
{
    public partial class ViewReport : UserControl
    {
        public ViewReport()
        {
            InitializeComponent();
        }

        private void ViewReport_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                CmbFilter.SelectedIndex = 0;


            }
        }

     /*   private void IncidentReportGrid()
        {
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            string sqlCommand = "SELECT bookheaders.ID AS ID, Title, ISBN, Author, Edition, Publisher, PublicationYear, AvailableQty, Name AS Category FROM bookheaders " +
                "JOIN bookcategories ON bookheaders.CategoryId = bookcategories.ID WHERE Status='active' AND AvailableQty > 0";
            if (CmbFilter.SelectedItem.Equals("Incident Report"))
            {
                string FilterField = CmbFilter.SelectedItem.ToString();
                sqlCommand += " AND " + FilterField + " LIKE '%" + SearchKey + "%'";
            }
            else
            {
                sqlCommand += " AND (Title LIKE '%" + SearchKey + "%' " +
                    "OR ISBN LIKE '%" + SearchKey + "%' " +
                    "OR Author LIKE '%" + SearchKey + "%' " +
                    "OR Publisher LIKE '%" + SearchKey + "%' " +
                    "OR Name LIKE '%" + SearchKey + "%' " +
                    "OR PublicationYear LIKE '%" + SearchKey + "%')";
            }

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            GridBooks.DataSource = ds.Tables[0];
            dbConnection.Close();
        }
     */
    }
}
