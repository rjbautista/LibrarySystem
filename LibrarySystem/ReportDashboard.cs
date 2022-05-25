using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class ReportDashboard : UserControl
    {
        public ReportDashboard()
        {
            InitializeComponent();
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            PrintReport PrintReport = new PrintReport();
            PrintReport.LoadBooks();
            PrintReport.Show();
        }

        private void BtnBookDetail_Click(object sender, EventArgs e)
        {
            PrintReport PrintReport = new PrintReport();
            PrintReport.LoadBookTitles();
            PrintReport.Show();
        }

        private void BtnBookTxn_Click(object sender, EventArgs e)
        {
            PrintBookTxn PrintBookTxn = new PrintBookTxn();
            PrintBookTxn.Show();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            PrintUsers PrintUsers = new PrintUsers();
            PrintUsers.Show();
        }
    }
}
