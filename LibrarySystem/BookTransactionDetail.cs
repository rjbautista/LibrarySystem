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
using ComponentFactory.Krypton.Toolkit;

namespace LibrarySystem
{
    public partial class BookTransactionDetail : KryptonForm
    {
        string BookHeaderId = "";
        string BookDetailId = "";
        string BookTxnHeaderId = "";
        string BookTxnDetailId = "";
        string BorrowerId = "";
        string AdminId = "";

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

                // Check the transaction details if bookdetail has a value, we will consider it as unreturned/missing..
                MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                SqlCommand = "SELECT * FROM booktxndetails WHERE BookTxnHeaderId='" + BookTxnHeaderId + "'";
                MySqlCommand command = new MySqlCommand(SqlCommand, dbConnection);
                dbConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string BookHeaderId = reader["BookHeaderId"].ToString();
                    string BookDetailId = reader["BookDetailId"].ToString();

                    if (!BookDetailId.Equals(""))
                    {
                        // Create booklog.
                        string BookNote = "Borrowed by " + LblName.Text + " with USN: " + LblUsn.Text + " " + LblCourse.Text + ". \nTransaction ID: " + BookTxnHeaderId;
                        SqlCommand = "INSERT INTO booklogs (BookHeaderId,BookDetailId, Description, UserId) VALUES ('" + BookHeaderId + "', '" + BookDetailId + "', '" + BookNote + "', '" + AdminId + "')";
                        Helper.DB.ExecuteNonQuery(SqlCommand);
                    }

                    Model.Book.UpdateBookCount(BookHeaderId);
                }
                dbConnection.Close();

                Form Main = Application.OpenForms["Main"];
                Button BtnRequest = Main.Controls.Find("BtnRequest", true).FirstOrDefault() as Button;
                BtnRequest.PerformClick();

                this.Close();
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure you want to complete this Book Request?\n Please make sure that all books have been returned otherwise it will be tagged as missing/unreturned.", "Confirm Book Return", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                string BookTxnHeaderId = LblTxnNo.Text;
                string SqlCommand = "UPDATE booktxnheaders SET Status='Returned', ReturnDate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE ID='" + BookTxnHeaderId + "' LIMIT 1";
                Helper.DB.ExecuteNonQuery(SqlCommand);

                // Check the transaction details if bookdetail has a value, we will consider it as unreturned/missing..
                MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                SqlCommand = "SELECT * FROM booktxndetails WHERE BookTxnHeaderId='" + BookTxnHeaderId + "'";
                MySqlCommand command = new MySqlCommand(SqlCommand, dbConnection);
                dbConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string BookHeaderId = reader["BookHeaderId"].ToString();
                    string BookDetailId = reader["BookDetailId"].ToString();
                    bool IsReturn = (bool)reader["IsReturned"];

                    if (!IsReturn) {
                        // update bookdetail and set the book to back available.
                        string BookNote = "This book has not been returned by " + LblName.Text + " with USN: " + LblUsn.Text + " " + LblCourse.Text + ". \nTransaction ID: " + BookTxnHeaderId;
                        SqlCommand = "UPDATE bookdetails SET Status='unreturned', IsAvailable=0, Note='" + BookNote + "' WHERE ID='" + BookDetailId + "'";
                        Helper.DB.ExecuteNonQuery(SqlCommand);
                    }

                    Model.Book.UpdateBookCount(BookHeaderId);
                }
                dbConnection.Close();

                Form Main = Application.OpenForms["Main"];
                Button BtnReturn = Main.Controls.Find("BtnReturn", true).FirstOrDefault() as Button;
                BtnReturn.PerformClick();

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

                Form Main = Application.OpenForms["Main"];
                Button BtnReturn = Main.Controls.Find("BtnReturn", true).FirstOrDefault() as Button;
                BtnReturn.PerformClick();
            }
        }

        private void BookTransactionDetail_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.LoadTxnRequestDetail();
                if (GridTxnDetail.SelectedRows.Count > 0)
                {
                    GridTxnDetail.Rows[0].Selected = true;
                }
                this.LoadBookDetail();
                UpdateBorrowerDetail();
                this.UpdateNote();

                Form Main = Application.OpenForms["Main"];
                Control LblAdminId = Main.Controls.Find("LblUserId", true)[0];
                AdminId = LblAdminId.Text;

                switch (LblTxnType.Text)
                {
                    case "Request":
                        BtnReturn.Visible = false;
                        BtnConfirm.Visible = true;
                        BtnDecline.Visible = true;
                        BtnAssign.Visible = true;
                        BtnUnassign.Text = "Unassign >>";
                        BtnReturnAll.Visible = false;

                        break;

                    case "Borrowed":
                        BtnReturn.Visible = true;
                        BtnConfirm.Visible = false;
                        BtnDecline.Visible = false;
                        BtnAssign.Visible = false;
                        BtnUnassign.Text = "Return book >>";
                        BtnReturnAll.Visible = true;
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

            if (LblTxnType.Text.Equals("Borrowed"))
            {
                SqlCommand += " AND btd.IsReturned=0";
            }

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
            } else {
                GridBookDetail.DataSource = null;
                GridBookDetail.Refresh();
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
                string BookTitle = row.Cells[4].Value.ToString();
                if (BookNo.Equals(""))
                {
                    BtnUnassign.Enabled = false;
                }
                else
                {
                    BtnUnassign.Enabled = true;
                }
                BtnAssign.Enabled = true;

                LblIssueBook.Text = "Issue book for " + BookTitle;

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
                string SqlCommand = "";

                if (LblTxnType.Text.Equals("Borrowed"))
                {
                    DialogResult Result = MessageBox.Show("Return selected book?", "Return book", MessageBoxButtons.YesNo);
                    if (Result == DialogResult.Yes)
                    {
                        // update bookdetail and set the book to back available.
                        SqlCommand = "UPDATE bookdetails SET Status='active', IsAvailable=1, UserId=NULL WHERE ID='" + BookDetailId + "'";
                        Helper.DB.ExecuteNonQuery(SqlCommand);

                        // update txndetail with the bookdetail
                        SqlCommand = "UPDATE booktxndetails SET IsReturned=1, ReturnDate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                            "WHERE BookHeaderId='" + BookHeaderId + "' AND BookTxnHeaderId='" + BookTxnHeaderId + "' AND ID='" + BookTxnDetailId + "' AND UserId='" + LblUserId.Text + "'";
                        Helper.DB.ExecuteNonQuery(SqlCommand);

                        // Create booklog.
                        string BookNote = "Returned by " + LblName.Text + " with USN: " + LblUsn.Text + " " + LblCourse.Text + ". \nTransaction ID: " + BookTxnHeaderId;
                        SqlCommand = "INSERT INTO booklogs (BookHeaderId,BookDetailId, Description, UserId) VALUES ('" + BookHeaderId + "', '" + BookDetailId + "', '" + BookNote + "', '" + AdminId + "')";
                        Helper.DB.ExecuteNonQuery(SqlCommand);

                        // update total available book count.
                        Model.Book.UpdateBookCount(BookHeaderId);

                        // refresh grids
                        LoadTxnRequestDetail();
                        LoadBookDetail();
                    }
                }
                else
                {
                    // update bookdetail and set the book to back available.
                    SqlCommand = "UPDATE bookdetails SET Status='active', IsAvailable=1, UserId=NULL WHERE ID='" + BookDetailId + "'";
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
            Form IRForm = new IRForm();

            Label LblIrNumber = IRForm.Controls.Find("LblIrNumber", true).FirstOrDefault() as Label;
            LblIrNumber.Text = DateTime.Now.ToString("yymmddhhmmss");


            Label IrLblName = IRForm.Controls.Find("LblName", true).FirstOrDefault() as Label;
            IrLblName.Text = LblName.Text;

            Label IrLblUsn = IRForm.Controls.Find("LblUsn", true).FirstOrDefault() as Label;
            IrLblUsn.Text = LblUsn.Text;

            Label IrLblCourse = IRForm.Controls.Find("LblCourse", true).FirstOrDefault() as Label;
            IrLblCourse.Text = LblCourse.Text;

            Label IrLblTxnNo = IRForm.Controls.Find("LblTxnNo", true).FirstOrDefault() as Label;
            IrLblTxnNo.Text = LblTxnNo.Text;

            Label IrLblStudentId = IRForm.Controls.Find("LblStudentId", true).FirstOrDefault() as Label;
            IrLblStudentId.Text = LblUserId.Text;

            Label IrLblTxnHeaderId = IRForm.Controls.Find("LblTxnHeaderId", true).FirstOrDefault() as Label;
            IrLblTxnHeaderId.Text = LblTxnNo.Text;
            

            IRForm.Show();
        }

        private void BtnReturnAll_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure you want return all the books?", "Return all books", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                string BookTxnHeaderId = LblTxnNo.Text;
                string SqlCommand = "UPDATE booktxnheaders SET Status='Returned', ReturnDate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE ID='" + BookTxnHeaderId + "' LIMIT 1";
                Helper.DB.ExecuteNonQuery(SqlCommand);

                // Check the transaction details if bookdetail has a value, we will consider it as unreturned/missing..
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
                    SqlCommand = "UPDATE booktxndetails SET IsReturned=1, ReturnDate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                        "WHERE BookHeaderId='" + BookHeaderId + "' AND BookTxnHeaderId='" + BookTxnHeaderId + "' AND ID='" + BookTxnDetailId + "' AND UserId='" + LblUserId.Text + "'";
                    Helper.DB.ExecuteNonQuery(SqlCommand);

                    // Create booklog.
                    string BookNote = "Returned by " + LblName.Text + " with USN: " + LblUsn.Text + " " + LblCourse.Text + ". \nTransaction ID: " + BookTxnHeaderId;
                    SqlCommand = "INSERT INTO booklogs (BookHeaderId,BookDetailId, Description, UserId) VALUES ('" + BookHeaderId + "', '" + BookDetailId + "', '" + BookNote + "', '" + AdminId + "')";
                    Helper.DB.ExecuteNonQuery(SqlCommand);

                    Model.Book.UpdateBookCount(BookHeaderId);
                }
                dbConnection.Close();

                // refresh grids
                LoadTxnRequestDetail();
                LoadBookDetail();
            }
        }
    }
}
