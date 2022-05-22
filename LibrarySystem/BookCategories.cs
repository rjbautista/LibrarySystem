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
    public partial class BookCategories : UserControl
    {
        public BookCategories()
        {
            InitializeComponent();
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            string sqlCommand = "INSERT INTO bookcategories (Name) VALUES ('" + txtCategoryName.Text + "')";

            dbConnection.Open();
            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            command.ExecuteNonQuery();
            dbConnection.Close();

            RefreshGrid();
        }

        private void BookCategories_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            //Helper.DB.openConnection();
            //DataSet ds = Model.BookCategory.GetDataSet();
            //gridBookCategory.DataSource = ds.Tables[0];
            //Helper.DB.closeConnection();
        }

        private void RefreshGrid()
        {
            string conn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            MySqlConnection dbConnection = new MySqlConnection(conn);

            string sqlCommand = "SELECT * FROM bookcategories";

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            gridBookCategory.DataSource = ds.Tables[0];
            dbConnection.Close();
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            grpNewForm.Visible = true;
            btnSaveCategory.Visible = true;
            btnCancel.Visible = true;
            btnNewCategory.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSaveCategory.Visible = false;
            btnCancel.Visible = false;
            btnNewCategory.Enabled = true;
        }

        private void gridBookCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridBookCategory_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridBookCategory.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();
                //...
            }
        }

    }
}
