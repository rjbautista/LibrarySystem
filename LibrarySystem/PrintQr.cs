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
using ComponentFactory.Krypton.Toolkit;

namespace LibrarySystem
{
    public partial class PrintQr : KryptonForm
    {
        public string UserId = "";
        public PrintQr()
        {
            InitializeComponent();
        }

        private void PrintQr_Load(object sender, EventArgs e)
        {

            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            string sqlCommand = "SELECT * FROM users WHERE ID='" + LblUserId.Text + "'";

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "DataTable_Users");

            for (int i = 0; i < ds.Tables["DataTable_Users"].Rows.Count; i++)
            {
                Uri QrFilePath = new Uri(Directory.GetCurrentDirectory() + "/" + ds.Tables["DataTable_Users"].Rows[i]["QR"].ToString());
                ds.Tables["DataTable_Users"].Rows[i]["QR"] = QrFilePath.AbsoluteUri;
            }

            ReportDataSource datasource = new ReportDataSource("DataSet_Report", ds.Tables[0]);
            dbConnection.Close();

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.RefreshReport();
            
        }
    }
}
