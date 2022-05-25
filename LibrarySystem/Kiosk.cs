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
    public partial class Kiosk : KryptonForm
    {
        public Kiosk()
        {
            InitializeComponent();
        }

        private void Kiosk_Load(object sender, EventArgs e)
        {
            CmbFilter.SelectedIndex = 0;
            this.RefreshBookGrid();

            GridCart.Columns.Add("Qty", "Qty");
            GridCart.Columns.Add("ID", "ID");
            GridCart.Columns.Add("Title", "Title");
            GridCart.Columns.Add("ISBN", "ISBN");
            GridCart.Columns.Add("Author", "Author");
            GridCart.Columns.Add("Edition", "Edition");
            GridCart.Columns.Add("Publisher", "Publisher");
            GridCart.Columns.Add("PublicationYear", "PublicationYear");
            GridCart.Columns.Add("Category", "Category");

        }

        private void RefreshBookGrid(string SearchKey = "")
        {
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            string sqlCommand = "SELECT bookheaders.ID AS ID, Title, ISBN, Author, Edition, Publisher, PublicationYear, AvailableQty, Name AS Category FROM bookheaders " +
                "JOIN bookcategories ON bookheaders.CategoryId = bookcategories.ID WHERE Status='active' AND AvailableQty > 0";
            if (!SearchKey.Equals("") && !CmbFilter.SelectedItem.Equals("Any"))
            {
                string FilterField = CmbFilter.SelectedItem.ToString();
                sqlCommand += " AND " + FilterField + " LIKE '%" + SearchKey + "%'";
            } else
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            RefreshBookGrid(TxtSearch.Text.Trim());
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSearch.PerformClick();
            }
        }

        private void Kiosk_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (GridBooks.SelectedRows.Count > 0)
            {
                int MaxCartItemCount = 3;
                foreach (DataGridViewRow Row in GridBooks.SelectedRows)
                {
                    int CurrentCartItemCount = GridCart.Rows.Count;

                    if (CurrentCartItemCount >= MaxCartItemCount)
                    {
                        MessageBox.Show("You have reached the maximum limit of " + MaxCartItemCount + " books.", "Add to cart", MessageBoxButtons.OK);
                        break;
                    }

                    string ID = Row.Cells["ID"].Value.ToString();
                    string Title = Row.Cells["Title"].Value.ToString();
                    string ISBN = Row.Cells["ISBN"].Value.ToString();
                    string Author = Row.Cells["Author"].Value.ToString();
                    string Edition = Row.Cells["Edition"].Value.ToString();
                    string Publisher = Row.Cells["Publisher"].Value.ToString();
                    string PublicationYear = Row.Cells["PublicationYear"].Value.ToString();
                    string AvailableQty = Row.Cells["AvailableQty"].Value.ToString();
                    string Category = Row.Cells["Category"].Value.ToString();

                    if (!ExistInCart(ID))
                    {
                        GridCart.Rows.Add(1, ID, Title, ISBN, Author, Edition, Publisher, PublicationYear, Category);
                    }
                }
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (GridCart.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow Row in GridCart.SelectedRows)
                {
                    GridCart.Rows.Remove(Row);
                }
            }
        }

        private bool ExistInCart(string ID)
        {
            bool Exist = false;
            foreach (DataGridViewRow Row in GridCart.Rows)
            {
                string CartBookID = Row.Cells["ID"].Value.ToString();
                if (CartBookID.Equals(ID))
                {
                    Exist = true;
                    break;
                }
            }
            return Exist;
        }

        private void BtnBorrow_Click(object sender, EventArgs e)
        {
            Form QrScanner = new QrScanner();
            QrScanner.Show();
        }

        private void BtnSendRequest_Click(object sender, EventArgs e)
        {
            if (!TxtUserId.Text.Equals(""))
            {
                string StudentUserId = TxtUserId.Text;
                /**
                 * TxnHeader Status:
                 * - Request
                 * - Declined
                 * - Borrowed
                 * - Completed
                 */
                string sqlCommand = "INSERT INTO booktxnheaders(UserId, Status) VALUES('" + StudentUserId + "', 'Request')";

                // create txn header
                MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                dbConnection.Open();
                MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
                command.ExecuteNonQuery();
                string insertedId = command.LastInsertedId.ToString();

                // create txn detail.
                foreach (DataGridViewRow Row in GridCart.Rows)
                {
                    String BookHeaderId = Row.Cells["ID"].Value.ToString();
                    sqlCommand = "INSERT INTO booktxndetails (BookTxnHeaderId, BookHeaderId, UserId) VALUES ('" + insertedId + "', '" + BookHeaderId + "', '" + StudentUserId + "')";
                    Helper.DB.ExecuteNonQuery(sqlCommand);
                }

                MessageBox.Show("Your request has been created. Please proceed to Librian desk.", "Request Complete", MessageBoxButtons.OK);
                GridCart.Rows.Clear();
                TxtUserId.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
         
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form Register = new Register();
            Register.Show();
        }
    }
}
