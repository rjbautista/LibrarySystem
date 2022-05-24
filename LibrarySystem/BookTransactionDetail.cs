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
    public partial class BookTransactionDetail : Form
    {
        string BookHeaderId = "";
        string BookDetailId = "";
        string BookTxnHeaderId = "";
        string BookTxnDetailId = "";
        string BorrowerId = "";

        public BookTransactionDetail()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure you want to Confirm and release the books for this Request?", "Confirm Request", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                string SqlCommand = "UPDATE booktxnheaders SET Status='Borrowed', BorrowDate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE ID='" + LblTxnNo.Text + "' LIMIT 1";
                Helper.DB.ExecuteNonQuery(SqlCommand);
                this.UpdateTxnHeaderGrid();
                this.Close();
            }
        }

        private void BtnDecline_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure you want to Decline this Request?", "Decline Request", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                string BookTxnHeaderId = LblTxnNo.Text;
                string SqlCommand = "UPDATE booktxnheaders SET Status='Declined', DeclineDate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE ID='" + BookTxnHeaderId + "' LIMIT 1";
                Helper.DB.ExecuteNonQuery(SqlCommand);
                this.UpdateTxnHeaderGrid();
                this.Close();

                // Put back all the books and it's inventory.
                MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                SqlCommand = "SELECT * FROM booktxndetails WHERE BookTxnHeaderId='" + BookTxnHeaderId + "'";
                MySqlCommand command = new MySqlCommand(SqlCommand, dbConnection);
                dbConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string BookTxnDetailId = reader["ID"].ToString();
                    string BookHeaderId = reader["BookHeaderId"].ToString();
                    string BookDetailId = reader["BookDetailId"].ToString();

                    // update bookdetail and set the book to back available.
                    SqlCommand = "UPDATE bookdetails SET Status='active', IsAvailable=1, UserId=NULL WHERE ID='" + BookDetailId + "'";
                    Helper.DB.ExecuteNonQuery(SqlCommand);

                    // update txndetail with the bookdetail
                    SqlCommand = "UPDATE booktxndetails SET BookDetailId=NULL, BorrowDate=NULL " +
                        "WHERE BookHeaderId='" + BookHeaderId + "' AND BookTxnHeaderId='" + BookTxnHeaderId + "' AND ID='" + BookTxnDetailId + "' AND UserId='" + LblUserId.Text + "'";
                    Helper.DB.ExecuteNonQuery(SqlCommand);

                    Model.Book.UpdateBookCount(BookHeaderId);
                }
                dbConnection.Close();
            }
        }

        private void BookTransactionDetail_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.LoadTxnRequestDetail();
                GridTxnDetail.Rows[0].Selected = true;
                this.LoadBookDetail();
                UpdateBorrowerDetail();
                this.UpdateNote();

                switch (LblTxnType.Text)
                {
                    case "Request":
                        BtnReturn.Visible = false;
                        BtnConfirm.Visible = true;
                        BtnDecline.Visible = true;
                        BtnAssign.Visible = true;
                        BtnUnassign.Text = "Unassign >>";

                        break;

                    case "Borrowed":
                        BtnReturn.Visible = true;
                        BtnConfirm.Visible = false;
                        BtnDecline.Visible = false;
                        BtnAssign.Visible = false;
                        BtnUnassign.Text = "Return Book";
                        break;
                }
            }
        }

        private void UpdateBorrowerDetail()
        {
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string sqlCommand = "SELECT u.* FROM booktxnheaders bth " +
                "LEFT JOIN users u ON bth.UserId = u.ID " +
                "WHERE bth.ID='" + LblTxnNo.Text + "'";

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                LblName.Text = reader["Name"].ToString();
                LblUsn.Text = reader["USN"].ToString();
                LblContact.Text = reader["ContactNo"].ToString();
                LblEmail.Text = reader["Email"].ToString();
                LblCourse.Text = reader["Course"].ToString();
                LblRole.Text = reader["Role"].ToString();
                LblEnrolled.Text = (bool)reader["IsEnrolled"] ? "Yes" : "No";
                LblVisitor.Text = (bool)reader["IsVisitor"] ? "Yes" : "No";
                LblUserId.Text = reader["ID"].ToString();
            }
            dbConnection.Close();
        }

        private void LoadTxnRequestDetail()
        {
            string SqlCommand = "SELECT btd.ID, btd.BookHeaderId, btd.BookDetailId, bd.BookNo, bh.Title, bh.Author, bh.Edition, bh.Publisher, bh.PublicationYear " +
                "FROM booktxndetails btd " +
                "LEFT JOIN bookheaders bh " +
                    "ON bh.ID = btd.BookHeaderId " +
                "LEFT JOIN bookdetails bd " +
                    "ON bd.ID = btd.BookDetailId " +
                "WHERE btd.BookTxnHeaderId='" + LblTxnNo.Text + "'";

            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            MySqlCommand command = new MySqlCommand(SqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            GridTxnDetail.DataSource = ds.Tables[0];
            dbConnection.Close();
            if (GridTxnDetail.SelectedRows.Count > 0)
            {
                BtnUnassign.Enabled = true;
            } else
            {
                BtnUnassign.Enabled = false;
            }
        }

        private void LoadBookDetail()
        {
            if (GridTxnDetail.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridTxnDetail.SelectedRows[0];
                string BookHeaderId = row.Cells[1].Value.ToString();

                MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

                string sqlCommand = "SELECT ID, BookNo, Note FROM bookdetails WHERE BookHeaderId='" + BookHeaderId + "' AND IsAvailable=1 AND Status='active'";
                MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
                dbConnection.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds);
                GridBookDetail.DataSource = ds.Tables[0];
                dbConnection.Close();

                if (GridBookDetail.SelectedRows.Count > 0) {
                    BtnAssign.Enabled = true;
                }
                else
                {
                    BtnAssign.Enabled = false;
                }
            }
        }

        private void GridTxnDetail_SelectionChanged(object sender, EventArgs e)
        {
            if (GridTxnDetail.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridTxnDetail.SelectedRows[0];
                BookTxnDetailId = row.Cells[0].Value.ToString();
                BookHeaderId = row.Cells[1].Value.ToString();
                BookTxnHeaderId = LblTxnNo.Text;
                BorrowerId = LblUserId.Text;

                string BookNo = row.Cells[3].Value.ToString();
                if (BookNo.Equals(""))
                {
                    BtnUnassign.Enabled = false;
                }
                else
                {
                    BtnUnassign.Enabled = true;
                }
                BtnAssign.Enabled = true;


                this.LoadBookDetail();
            }
        }

        private void GridBookDetail_SelectionChanged(object sender, EventArgs e)
        {
            if (GridBookDetail.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridBookDetail.SelectedRows[0];
                BookDetailId = row.Cells[0].Value.ToString();

                BtnAssign.Enabled = true;
                BtnUnassign.Enabled = true;
            }

        }
        

        private void UpdateTxnHeaderGrid()
        {
            Form Main= Application.OpenForms["Main"];
            Control UControlBookTransaction = Main.Controls.Find("UControlBookTransaction", true)[0];
            UControlBookTransaction.Refresh();
        }

        private void BtnAssign_Click(object sender, EventArgs e)
        {
            if (GridTxnDetail.SelectedRows.Count > 0 && GridBookDetail.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridTxnDetail.SelectedRows[0];
                string BookNo = row.Cells[3].Value.ToString();
                // If there's an existing book, remove it first and then assign the new one.
                if (!BookNo.Equals(""))
                {
                    int SelectedBookIndex = GridBookDetail.SelectedRows[0].Index;
                    BtnUnassign.PerformClick();
                    GridBookDetail.Rows[SelectedBookIndex].Selected = true;
                }

                // update bookdetail and set the book to unavailable.
                string SqlCommand = "UPDATE bookdetails SET Status='borrowed', IsAvailable=0, UserId='" + LblUserId.Text + "' WHERE ID='" + BookDetailId + "'";
                Helper.DB.ExecuteNonQuery(SqlCommand);

                // update txndetail with the bookdetail
                SqlCommand = "UPDATE booktxndetails SET BookDetailId='" + BookDetailId + "', BorrowDate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                    " WHERE BookHeaderId='" + BookHeaderId + "' AND BookTxnHeaderId='" + BookTxnHeaderId + "' AND ID='" + BookTxnDetailId + "' AND UserId='" + LblUserId.Text + "'";
                Helper.DB.ExecuteNonQuery(SqlCommand);

                // update total available book count.
                Model.Book.UpdateBookCount(BookHeaderId);

                // refresh grids
                LoadTxnRequestDetail();
                LoadBookDetail();
            }
        }

        private void BtnUnassign_Click(object sender, EventArgs e)
        {
            if (GridTxnDetail.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridTxnDetail.SelectedRows[0];
                string BookDetailId = row.Cells[2].Value.ToString();

                // update bookdetail and set the book to back available.
                string SqlCommand = "UPDATE bookdetails SET Status='active', IsAvailable=1, UserId=NULL WHERE ID='" + BookDetailId + "'";
                Helper.DB.ExecuteNonQuery(SqlCommand);

                // update txndetail with the bookdetail
                SqlCommand = "UPDATE booktxndetails SET BookDetailId=NULL, BorrowDate=NULL " +
                    "WHERE BookHeaderId='" + BookHeaderId + "' AND BookTxnHeaderId='" + BookTxnHeaderId + "' AND ID='" + BookTxnDetailId + "' AND UserId='" + LblUserId.Text + "'";
                Helper.DB.ExecuteNonQuery(SqlCommand);

                // update total available book count.
                Model.Book.UpdateBookCount(BookHeaderId);

                // refresh grids
                LoadTxnRequestDetail();
                LoadBookDetail();
            }
        }

        private void BtnSaveNote_Click(object sender, EventArgs e)
        {
            string note = "Entered on:" + DateTime.Now.ToString() + "\n\n" +
                TxtNewNote.Text.Trim() +
                "\n----------\n\n";

            // update txndetail with the bookdetail
            string SqlCommand = "UPDATE booktxnheaders SET  Note='" + 
                TxtNote.Text + note + "'" +
                "WHERE ID = '" + LblTxnNo.Text + "' LIMIT 1";
            Helper.DB.ExecuteNonQuery(SqlCommand);

            this.UpdateNote();

            TxtNewNote.Text = "";
        }

        private void UpdateNote()
        {

            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string sqlCommand = "SELECT * FROM booktxnheaders WHERE ID='" + LblTxnNo.Text + "'";
            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                TxtNote.Text = reader["Note"].ToString();
            }
            dbConnection.Close();
        }

        private void BtnIncident_Click(object sender, EventArgs e)
        {

        }
    }
}
