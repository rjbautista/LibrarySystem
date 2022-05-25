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
using System.Text.RegularExpressions;


namespace LibrarySystem
{
    public partial class Books : UserControl
    {
        private Boolean IsEditing = false;
        private string EditingId = "";

        public Books()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidForm())
            {

                string Title = TxtTitle.Text.Trim();
                string Isbn = TxtIsbn.Text.Trim();
                string Author = TxtAuthor.Text.Trim();
                string Edition = TxtEdition.Text.Trim();
                string Publisher = TxtPublisher.Text.Trim();
                string Category = CmbCategory.SelectedValue.ToString();
                string Year = TxtYear.Text.Trim();
                string Status = CmbStatus.SelectedItem.ToString();
                Decimal Qty = txtQty.Value;

                string action = "created";

                string sqlCommand = "INSERT INTO bookheaders (ISBN,  Title,  Author,  Edition,  Publisher,  PublicationYear,  AvailableQty,  TotalQty,  CategoryId,  Status) " +
                    " VALUES ('" + Isbn + "', '" + Title + "', '" + Author + "', '" + Edition + "', '" + Publisher + "', '" + Year + "', '" + Qty + "', '" + Qty + "', '" + Category + "', '" + Status + "')";

                if (IsEditing)
                {
                    sqlCommand = "UPDATE bookheaders SET " +
                        "ISBN='" + Isbn + "'," +
                        "Title='" + Title + "'," +
                        "Author='" + Author + "'," +
                        "Edition='" + Edition + "'," +
                        "Publisher='" + Publisher + "'," +
                        "PublicationYear='" + Year + "'," +
                        "AvailableQty='" + Qty + "'," +
                        "TotalQty='" + Qty + "'," +
                        "CategoryId='" + Category + "'," +
                        "Status='" + Status + "'," +
                        "LastUpdated='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                        "WHERE ID = " + EditingId + " LIMIT 1";
                    GrpNewForm.Visible = false;
                    this.clearForm();
                    action = "updated";
                }

                MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                dbConnection.Open();
                MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
                command.ExecuteNonQuery();
                string insertedId = command.LastInsertedId.ToString();

                if (IsEditing)
                {
                    insertedId = EditingId;
                }

                dbConnection.Close();

                // create book log history
                Form Main = Application.OpenForms["Main"];
                Control UserId = Main.Controls.Find("LblUserId", true)[0];
                string description = "Book has been " + action + ". Details below:\r\n " +
                    "ISBN=" + Isbn + "," +
                    "Title=" + Title + "," +
                    "Author=" + Author + "," +
                    "Edition=" + Edition + "," +
                    "Publisher=" + Publisher + "," +
                    "PublicationYear=" + Year + "," +
                    "TotalQty=" + Qty + "," +
                    "CategoryId=" + Category + "," +
                    "Status=" + Status;
                sqlCommand = "INSERT INTO booklogs (BookHeaderId, Description, UserId) VALUES ('" + insertedId + "', '" + description + "', '" + UserId.Text + "')"; 
                Helper.DB.ExecuteNonQuery(sqlCommand);

                TxtTitle.Clear();
                IsEditing = false;
                EditingId = "";
                this.RefreshGrid();

                BtnNew.Enabled = true;
                BtnEdit.Enabled = true;
                BtnDelete.Enabled = true;
                GridBooks.Enabled = true;
                this.clearForm();
            }
        }

        private void Books_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.RefreshGrid();
                this.loadCategories();
                GridBooks.ClearSelection();
                CmbCategory.SelectedIndex = 0;
                CmbStatus.SelectedIndex = 0;
                CmbFilter.SelectedItem = "Title";
            }
        }

        public void RefreshGrid(string SearchKey = "")
        {
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            string sqlCommand = "SELECT ID, ISBN, Title, Author, Edition, Publisher, PublicationYear, AvailableQty, TotalQty, CategoryId, Status, Created FROM bookheaders";
            if (!SearchKey.Equals(""))
            {
                string FilterField = CmbFilter.SelectedItem.ToString();
                sqlCommand += " WHERE " + FilterField + " LIKE '%" + SearchKey + "%'";
            }

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            GridBooks.DataSource = ds.Tables[0];
            dbConnection.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            GrpNewForm.Visible = true;
            BtnNew.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            BtnView.Enabled = false;
            GridBooks.Enabled = false;
            this.clearForm();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            GrpNewForm.Visible = false;
            IsEditing = false;
            EditingId = "";

            BtnNew.Enabled = true;
            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            BtnView.Enabled = true;
            GridBooks.Enabled = true;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            RefreshGrid(TxtSearch.Text.Trim());
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (GridBooks.SelectedRows.Count > 0)
            {
                IsEditing = true;
                DataGridViewRow row = GridBooks.SelectedRows[0];
                EditingId = row.Cells[0].Value.ToString();

                MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                string sqlCommand = "SELECT * FROM bookheaders WHERE ID='" + EditingId + "'";

                MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
                dbConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();

                    TxtTitle.Text = reader["Title"].ToString();
                    TxtIsbn.Text = reader["ISBN"].ToString();
                    TxtAuthor.Text = reader["Author"].ToString();
                    TxtEdition.Text = reader["Edition"].ToString();
                    TxtPublisher.Text = reader["Publisher"].ToString();
                    CmbCategory.SelectedValue = reader["CategoryId"].ToString();
                    TxtYear.Text = reader["PublicationYear"].ToString();
                    CmbStatus.SelectedItem = reader["Status"].ToString();
                    txtQty.Value = (int)reader["TotalQty"];

                    GrpNewForm.Visible = true;
                }
                dbConnection.Close();
            }
            BtnNew.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            BtnView.Enabled = false;
            GridBooks.Enabled = false;
        }

        private void GridBookCategory_SelectionChanged(object sender, EventArgs e)
        {

            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            BtnView.Enabled = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GridBooks.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this book?", "Confirm remove", MessageBoxButtons.YesNo);
                if (dialogResult.Equals(DialogResult.Yes)) {
                    DataGridViewRow row = GridBooks.SelectedRows[0];
                    string Id = row.Cells[0].Value.ToString();
                    Helper.DB.ExecuteNonQuery("UPDATE bookheaders SET Status='deactivated' WHERE ID = '" + Id + "' LIMIT 1");
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

        private Boolean ValidForm()
        {
            Boolean isValid = false;

            string Title = TxtTitle.Text.Trim();


            if (Title.Length < 1)
            {
                MessageBox.Show("Please enter a valid Title.", "Account Information", MessageBoxButtons.OK);
                TxtTitle.Focus();
                return isValid;
            }

            isValid = true;

            return isValid;
        }


        private void loadCategories()
        {
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string sqlCommand = "SELECT * FROM bookcategories";

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            CmbCategory.DataSource = ds.Tables[0];
            CmbCategory.DisplayMember = "Name";
            CmbCategory.ValueMember = "ID";
            dbConnection.Close();
        }

        private void clearForm() {
            TxtTitle.Clear();
            TxtIsbn.Clear();
            TxtAuthor.Clear();
            TxtEdition.Clear();
            TxtPublisher.Clear();
            TxtYear.Clear();
            txtQty.Value = 0;
            CmbCategory.SelectedIndex = 0;
            CmbStatus.SelectedIndex = 0;
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            if (GridBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridBooks.SelectedRows[0];
                Form BookDetails = new BookDetails();

                string BookId = row.Cells[0].Value.ToString();
                Control LblBookId = BookDetails.Controls.Find("LblBookId", true)[0];
                LblBookId.Text = BookId;

                string Title = row.Cells[2].Value.ToString();
                Control LblBooktitle = BookDetails.Controls.Find("LblBooktitle", true)[0];
                LblBooktitle.Text = Title;
                
                BookDetails.Show();
            }
        }

        private void GridBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
