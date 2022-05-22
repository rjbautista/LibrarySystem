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
                reader.Read();

                Form Main = new Main();
                Control LblUsername = Main.Controls.Find("LblUsername", true)[0];
                Control LblUserId = Main.Controls.Find("LblUserId", true)[0];
                LblUsername.Text = reader["Name"].ToString();
                LblUserId.Text = reader["ID"].ToString();
                Main.Show();
                this.Close();
            } else
            {
                MessageBox.Show("Invalid combination of USN/Employee number and password.", "Login", MessageBoxButtons.OK);
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form Start = Application.OpenForms["Start"];
            Start.Show();

            this.Close();
        }
    }
}
