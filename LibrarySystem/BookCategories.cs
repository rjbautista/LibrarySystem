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
        private Boolean IsEditing = false;
        private string EditingId = "";

        public BookCategories()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtName.Text.Trim().Length > 0)
            {

                string sqlCommand = "INSERT INTO bookcategories (Name) VALUES ('" + TxtName.Text + "')";

                if (IsEditing)
                {
                    sqlCommand = "UPDATE bookcategories SET Name = '" + TxtName.Text + "' WHERE ID = " + EditingId;
                    GrpNewForm.Visible = false;
                }

                Helper.DB.ExecuteNonQuery(sqlCommand);
                TxtName.Clear();
                IsEditing = false;
                EditingId = "";
                this.RefreshGrid();
            }
            BtnNew.Enabled = true;
            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            GridBookCategory.Enabled = true;
        }

        private void BookCategories_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.RefreshGrid();
                GridBookCategory.ClearSelection();
            }
        }

        private void RefreshGrid(string SearchKey = "")
        {
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            string sqlCommand = "SELECT * FROM bookcategories";
            if (!SearchKey.Equals(""))
            {
                sqlCommand += " WHERE Name LIKE '%" + SearchKey + "%'";
            }

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            GridBookCategory.DataSource = ds.Tables[0];
            dbConnection.Close();
        }

        private void BtnNewCategory_Click(object sender, EventArgs e)
        {
            GrpNewForm.Visible = true;
            TxtName.Text = "";
            BtnNew.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            GrpNewForm.Visible = false;
            IsEditing = false;
            EditingId = "";
            BtnNew.Enabled = true;
            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            RefreshGrid(TxtSearch.Text.Trim());
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (GridBookCategory.SelectedRows.Count > 0)
            {
                IsEditing = true;
                foreach (DataGridViewRow row in GridBookCategory.SelectedRows)
                {
                    EditingId = row.Cells[0].Value.ToString();
                    string Name = row.Cells[1].Value.ToString();

                    TxtName.Text = Name;
                    GrpNewForm.Visible = true;
                }

                BtnNew.Enabled = false;
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = false;
                GridBookCategory.Enabled = false;
            }
        }

        private void GridBookCategory_SelectionChanged(object sender, EventArgs e)
        {
            
            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GridBookCategory.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm delete", MessageBoxButtons.YesNo);
                if (dialogResult.Equals(DialogResult.Yes)) {
                    DataGridViewRow row = GridBookCategory.SelectedRows[0];
                    string Id = row.Cells[0].Value.ToString();
                    Helper.DB.ExecuteNonQuery("DELETE FROM bookcategories WHERE ID = '" + Id + "' LIMIT 1");
                    this.RefreshGrid();
                }
            }
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSearch.PerformClick();
            }
        }
    }
}
