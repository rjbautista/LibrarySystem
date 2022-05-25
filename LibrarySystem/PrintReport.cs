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
using System.IO;

namespace LibrarySystem
{
    public partial class PrintReport : Form
    {
        public PrintReport()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

           
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            LoadBookDetail();
        }

        public void LoadBooks()
        {
            GrpBookTitle.Visible = false;

            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            string sqlCommand = "SELECT Title, ISBN, Author, Publisher, PublicationYear, bookcategories.Name AS Category, AvailableQty, TotalQty, Status, Created FROM bookheaders LEFT JOIN bookcategories ON bookcategories.ID = bookheaders.CategoryId";

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "DataTable_Books");

            ReportDataSource datasource = new ReportDataSource("DataSet_Report", ds.Tables[0]);
            dbConnection.Close();

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LibrarySystem.Reports.RptBooks.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.RefreshReport();
        }


        private void LoadBookDetail()
        {
            // Get the Book header details
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string sqlCommand = "SELECT Title, ISBN, Author, Publisher, PublicationYear, bookcategories.Name AS Category, AvailableQty, TotalQty, Status, Created FROM bookheaders LEFT JOIN bookcategories ON bookcategories.ID = bookheaders.CategoryId";

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "DataTable_Books");

            ReportDataSource BookDataSource = new ReportDataSource("DataSet_Book", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Add(BookDataSource);
            dbConnection.Close();

            // Get the Book header details
            sqlCommand = "SELECT BookNo, IF(IsAvailable = 1, 'Yes', 'No') AS Available, UCASE(Status) as Status, Created, Note from bookdetails WHERE BookHeaderId='" + CmbFilter.SelectedValue + "'";
            
            command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            dataAdapter = new MySqlDataAdapter(command);
            ds = new DataSet();

            dataAdapter.Fill(ds, "DataTable_BookDetails");

            ReportDataSource BookDtailDatasource = new ReportDataSource("DataSet_BookDetail", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Add(BookDtailDatasource);
            dbConnection.Close();

            // Get book details

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LibrarySystem.Reports.RptBookDetail.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(BookDataSource);
            this.reportViewer1.LocalReport.DataSources.Add(BookDtailDatasource);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.RefreshReport();
        }

        public void LoadBookTitles()
        {
            GrpBookTitle.Visible = true;
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string sqlCommand = "SELECT ID, Title FROM bookheaders";

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            CmbFilter.DataSource = ds.Tables[0];
            CmbFilter.DisplayMember = "Title";
            CmbFilter.ValueMember = "ID";
            CmbFilter.SelectedIndex = 0;
            dbConnection.Close();
        }
    }
}
