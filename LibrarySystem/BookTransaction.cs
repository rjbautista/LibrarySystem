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
    public partial class BookTransaction : UserControl
    {
        public BookTransaction()
        {
            InitializeComponent();
        }

        private void BookTransaction_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.RefreshGrid();
            }
        }

        public void RefreshGrid(string SearchKey = "")
        {
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string Transaction = LblTransaction.Text;
            string sqlCommand = "SELECT bh.ID, bh.RequestDate, u.USN, u.Name, U.Course, U.IsVisitor, U.IsEnrolled " +
                "FROM booktxnheaders bh " +
                "LEFT JOIN users u ON bh.UserId = u.ID " +
                "WHERE bh.Status = '" + Transaction + "'";

            if (!SearchKey.Equals(""))
            {
                sqlCommand += " AND u.Name LIKE '%" + SearchKey + "%' " +
                    " OR u.USN LIKE '%" + SearchKey + "%'";
            }

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            GridTransactions.DataSource = ds.Tables[0];
            dbConnection.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.RefreshGrid(TxtSearch.Text.Trim());
        }

        private void GridTransactions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnView.PerformClick();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            if (GridTransactions.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridTransactions.SelectedRows[0];
                string TxnHeaderId = row.Cells[0].Value.ToString();

                Form BookTxnDetail = new BookTransactionDetail();
                Control LblTxnNo = BookTxnDetail.Controls.Find("LblTxnNo", true)[0];
                Control LblTxnType = BookTxnDetail.Controls.Find("LblTxnType", true)[0];
                Control LblTxnDetailHeader = BookTxnDetail.Controls.Find("LblTxnDetailHeader", true)[0];

                LblTxnNo.Text = TxnHeaderId;
                LblTxnType.Text = LblTransaction.Text;
                BookTxnDetail.Show();
            }
        }

    }
}
