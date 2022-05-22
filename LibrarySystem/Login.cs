using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace LibrarySystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string sqlCommand = "SELECT * FROM users WHERE USN='" + txtUSN.Text + "' AND Password='" + txtPass.Text + "'";

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) {
                Form Main = new Main();
                Main.Show();
            }
            dbConnection.Close();
        }

        private void cmbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbShowPass.Checked) {
                txtPass.PasswordChar = '\0';
            } else {
                txtPass.PasswordChar = '\u25CF';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '\u25CF';
        }
    }
}
