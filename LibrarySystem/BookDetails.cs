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
    public partial class BookDetails : Form
    {
        private Boolean IsEditing = false;
        private string EditingId = "";

        public BookDetails()
        {
            InitializeComponent();
        }

        private void BookDetails_Load(object sender, EventArgs e)
        {
            this.RefreshBookGrid();
            this.RefreshHistoryGrid();
        }

        private void RefreshBookGrid()
        {
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            string sqlCommand = "SELECT ID, BookHeaderId, BookNo, IsAvailable, Status, Created, Note FROM bookdetails WHERE BookHeaderId='" + LblBookId.Text + "'";
            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            GridBooks.DataSource = ds.Tables[0];
            dbConnection.Close();
        }

        private void RefreshHistoryGrid(string BookDetailId = "")
        {
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            string sqlCommand = "SELECT Description, booklogs.Created AS Date, Name As User FROM booklogs " +
                "LEFT JOIN users ON booklogs.UserId = users.Id WHERE BookHeaderId='" + LblBookId.Text + "'";
            if (!BookDetailId.Equals(""))
            {
                sqlCommand += " AND BookDetailId = '" + BookDetailId + "'";
            }
            sqlCommand += " ORDER BY Date DESC";
            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            GridHistory.DataSource = ds.Tables[0];
            dbConnection.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            GrpNewForm.Visible = true;

            BtnNew.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidForm())
            {

                string BookNo = TxtBookNo.Text;
                string Note = !TxtNote.Text.Equals("") ? TxtNote.Text : "";
                int IsAvailable = ChkAvailable.Checked ? 1 : 0;
                string Status = CmbStatus.SelectedItem.ToString();
                string BookHeaderId = LblBookId.Text;

                string action = "created";

                string sqlCommand = "INSERT INTO bookdetails (BookHeaderId, BookNo, IsAvailable, Status, Note) " +
                    " VALUES ('" + BookHeaderId + "', '" + BookNo + "', '" + IsAvailable + "', '" + Status + "', '" + Note + "')";

                if (IsEditing)
                {
                    
                    sqlCommand = "UPDATE bookdetails SET " +
                        "BookNo='" + BookNo + "'," +
                        "IsAvailable='" + IsAvailable + "'," +
                        "Status='" + Status + "'," +
                        "Note='" + Note + "'," +
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
                    "BookNo=" + BookNo + "," +
                    "IsAvailable=" + IsAvailable + "," +
                    "Status=" + Status + "," +
                    "Note=" + Note + "," +
                    "Status=" + Status;
                sqlCommand = "INSERT INTO booklogs (BookHeaderId,BookDetailId, Description, UserId) VALUES ('" + BookHeaderId + "', '" + insertedId + "', '" + description + "', '" + UserId.Text + "')"; 
                Helper.DB.ExecuteNonQuery(sqlCommand);


                // update book header count
                int TotalActiveBook = Model.Book.GetActiveBookCountByHeaderId(BookHeaderId);
                int TotalBook = Model.Book.GetTotalBookCountByHeaderId(BookHeaderId);
                sqlCommand = "UPDATE bookheaders SET AvailableQty=" + TotalActiveBook + ", TotalQty=" + TotalBook + " WHERE ID=" + BookHeaderId;
                Helper.DB.ExecuteNonQuery(sqlCommand);

                IsEditing = false;
                EditingId = "";
                this.RefreshBookGrid();

                GrpNewForm.Visible = false;

                BtnNew.Enabled = true;
                BtnEdit.Enabled = true;
                BtnDelete.Enabled = true;
                this.clearForm();
            }


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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (GridBooks.SelectedRows.Count > 0)
            {
                IsEditing = true;
                DataGridViewRow row = GridBooks.SelectedRows[0];
                EditingId = row.Cells[0].Value.ToString();

                if (!EditingId.Equals(""))
                {
                    MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                    string sqlCommand = "SELECT * FROM bookdetails WHERE ID='" + EditingId + "'";

                    MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
                    dbConnection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();

                        TxtBookNo.Text = reader["BookNo"].ToString();
                        TxtNote.Text = reader["Note"].ToString();
                        ChkAvailable.Checked = (bool)reader["IsAvailable"]; ;
                        CmbStatus.SelectedItem = reader["Status"].ToString();
                        
                        GrpBorrowedBy.Visible = false;
                        lblBorrowedBy.Text = "";

                        if (!reader.IsDBNull(reader.GetOrdinal("UserId")))
                        {
                            string UseriId = reader["UserId"].ToString();
                            string UsnName = Model.User.GetUsnAndName(UseriId);
                            GrpBorrowedBy.Visible = true;
                            lblBorrowedBy.Text = UsnName;
                        }

                        GrpNewForm.Visible = true;
                    }
                    dbConnection.Close();
                    
                    GrpNewForm.Visible = true;
                    BtnNew.Enabled = false;
                    BtnEdit.Enabled = false;
                    BtnDelete.Enabled = false;
                }
            }
        }

        private void GridBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (GridBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridBooks.SelectedRows[0];
                string BookId = row.Cells[0].Value.ToString();

                this.RefreshHistoryGrid(BookId);
            }
        }

        private Boolean ValidForm()
        {
            Boolean isValid = false;

            string BookNo = TxtBookNo.Text.Trim();


            if (BookNo.Length < 1)
            {
                MessageBox.Show("Please enter a valid Book No.", "Book Information", MessageBoxButtons.OK);
                TxtBookNo.Focus();
                return isValid;
            }

            isValid = true;

            return isValid;
        }

        private void clearForm()
        {
            TxtBookNo.Clear();
            TxtNote.Clear();
            ChkAvailable.Checked = false;
            CmbStatus.SelectedIndex = 0;
            lblBorrowedBy.Text = "";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GridBooks.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to deactivate this book?", "Confirm remove", MessageBoxButtons.YesNo);
                if (dialogResult.Equals(DialogResult.Yes))
                {
                    DataGridViewRow row = GridBooks.SelectedRows[0];
                    string Id = row.Cells[0].Value.ToString();
                    Helper.DB.ExecuteNonQuery("UPDATE bookdetails SET Status='deactivated', IsAvailable=0 WHERE ID = '" + Id + "' LIMIT 1");

                    // create book log history
                    Form Main = Application.OpenForms["Main"];
                    Control UserId = Main.Controls.Find("LblUserId", true)[0];

                    string description = "Set to deactivated and not available.";
                    string sqlCommand = "INSERT INTO booklogs (BookHeaderId,BookDetailId, Description, UserId) VALUES ('" + LblBookId.Text + "', '" + Id + "', '" + description + "', '" + UserId.Text + "')";
                    Helper.DB.ExecuteNonQuery(sqlCommand);
                    this.RefreshBookGrid();
                }
            }
        }
    }
}
