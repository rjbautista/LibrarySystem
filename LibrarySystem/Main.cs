using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace LibrarySystem
{
    public partial class Main : KryptonForm
    {
        public string LoggedInUserId = "";
        public string LoggedInUserName = "";

        public Main()
        {
            InitializeComponent();
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            UControlUsers.BringToFront();
            UControlUsers.RefreshGrid();
        }

        private void BtnBooks_Click(object sender, EventArgs e)
        {
            UControlBooks.BringToFront();
            UControlBooks.RefreshGrid();
        }

        private void BtnMyAccount_Click(object sender, EventArgs e)
        {
            Form EditAccount = new EditAccount();
            EditAccount.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
           UControlHome.BringToFront();
         

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form Start = Application.OpenForms["Start"];
            Start.Show();
            this.Close();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            UControlHome.BringToFront();
          
        }

        private void BtnRequest_Click(object sender, EventArgs e)
        {
            UControlBookTransaction.BringToFront();
            Control LblTransaction = UControlBookTransaction.Controls.Find("LblTransaction", true)[0];
            LblTransaction.Text = "Request";
            UControlBookTransaction.RefreshGrid();

            Control LblBookTransaction = UControlBookTransaction.Controls.Find("LblBookTransaction", true)[0];
            LblBookTransaction.Text = "Book Requests";
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            UControlBookTransaction.BringToFront();
            Control LblTransaction = UControlBookTransaction.Controls.Find("LblTransaction", true)[0];
            LblTransaction.Text = "Borrowed";
            UControlBookTransaction.RefreshGrid();

            Control LblBookTransaction = UControlBookTransaction.Controls.Find("LblBookTransaction", true)[0];
            LblBookTransaction.Text = "Return a Book";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UControlProcessStudent.BringToFront();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            UControlReportDashboard.BringToFront();
        }
    }
}
