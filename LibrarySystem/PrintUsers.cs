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
    public partial class PrintUsers : Form
    {
        public PrintUsers()
        {
            InitializeComponent();
        }

        private void PrintUsers_Load(object sender, EventArgs e)
        {

            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            string sqlCommand = "SELECT * FROM users";

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "DataTable_Users");

            ReportDataSource datasource = new ReportDataSource("DataSet_User", ds.Tables[0]);
            dbConnection.Close();

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LibrarySystem.Reports.RptUsers.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.RefreshReport();
        }
    }
}
