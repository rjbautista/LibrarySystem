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
using Microsoft.Reporting.WinForms;

namespace LibrarySystem
{
    public partial class PrintBookTxn : Form
    {
        public PrintBookTxn()
        {
            InitializeComponent();
        }

        private void PrintBookTxn_Load(object sender, EventArgs e)
        {
            cmbFrom.Value = DateTime.Today;
            cmbFrom.Value = DateTime.Today;
            CmbFilter.SelectedIndex = 0;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            LoadBookTxn();
        }

        public void LoadBookTxn()
        {
            GrpBookTitle.Visible = false;

            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            string sqlCommand = "SELECT bh.ID as TxnID, bh.RequestDate, bh.BorrowDate, bh.ReturnDate, bh.DeclineDate, bh.Status, bh.Note AS TxnNote, " +
                "u.Name, u.USN, u.Course, b.Title, b.ISBN, b.Author, b.Edition, b.Publisher " +
                "FROM booktxnheaders bh " +
                "LEFT JOIN users u ON u.ID = bh.UserId " +
                "LEFT JOIN booktxndetails bd ON bd.BookTxnHeaderId = bh.ID " +
                "LEFT JOIN bookheaders b ON b.ID = bd.BookHeaderId";

            sqlCommand += " WHERE bh.Status='" + CmbFilter.SelectedItem.ToString() + "' ";

            switch (CmbFilter.SelectedValue)
            {
                case "Request":
                    sqlCommand += " WHERE bh.RequestDate >='" + cmbFrom.Value.ToString() + "' ";
                    if (cmbFrom.Value.ToString("yyyy/mm/dd") != cmbTo.Value.ToString("yyyy/mm/dd"))
                    {
                        sqlCommand += " AND bh.RequestDate <= '" + cmbTo.Value.ToString() + "'";
                    }
                        
                    break;

                case "Borrowed":
                    sqlCommand += " WHERE bh.BorrowDate >='" + cmbFrom.Value.ToString() + "' ";
                    if (cmbFrom.Value.ToString("yyyy/mm/dd") != cmbTo.Value.ToString("yyyy/mm/dd"))
                    {
                        sqlCommand += " AND bh.BorrowDate <= '" + cmbTo.Value.ToString() + "'";
                    }
                    
                    break;

                case "Returned":
                    sqlCommand += " WHERE bh.ReturnDate >='" + cmbFrom.Value.ToString() + "' ";
                    if (cmbFrom.Value.ToString("yyyy/mm/dd") != cmbTo.Value.ToString("yyyy/mm/dd"))
                    {
                        sqlCommand += "AND bh.ReturnDate <= '" + cmbTo.Value.ToString() + "'";
                    }
                    break;

                case "Decline":
                    sqlCommand += " WHERE bh.DeclineDate >='" + cmbFrom.Value.ToString() + "'";
                    if (cmbFrom.Value.ToString("yyyy/mm/dd") != cmbTo.Value.ToString("yyyy/mm/dd"))
                    {
                        sqlCommand += "AND bh.DeclineDate <= '" + cmbTo.Value.ToString() + "'";
                    }
                    
                    break;
            }


            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "DataTable_Txn");

            ReportDataSource datasource = new ReportDataSource("DataSet_Txn", ds.Tables[0]);
            dbConnection.Close();

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LibrarySystem.Reports.RptTxn.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
    }
}
