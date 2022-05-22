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
    public partial class Main : Form
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
        }

        private void BtnBooks_Click(object sender, EventArgs e)
        {
            UControlBooks.BringToFront();
        }

        private void BtnMyAccount_Click(object sender, EventArgs e)
        {
            Form EditAccount = new EditAccount();
            EditAccount.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form Start = Application.OpenForms["Start"];
            Start.Show();
            this.Close();
        }
    }
}
