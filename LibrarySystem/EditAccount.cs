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
using ComponentFactory.Krypton.Toolkit;

namespace LibrarySystem
{
    public partial class EditAccount : KryptonForm
    {
        public EditAccount()
        {
            InitializeComponent();
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            Form Main = Application.OpenForms["Main"];
            Control UserId = Main.Controls.Find("LblUserId", true)[0];
            

            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string sqlCommand = "SELECT * FROM users WHERE ID = " + UserId.Text;

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                LblUserId.Text = reader["Id"].ToString();
                TxtName.Text = reader["Name"].ToString();
                TxtUsn.Text = reader["USN"].ToString();
                cmbRole.SelectedItem = reader["Role"].ToString();
                cmbGender.SelectedItem = reader["Gender"].ToString();
                CmbPosition.SelectedItem = reader["Position"].ToString();
                CmbCourse.SelectedItem = reader["Course"].ToString();
                TxtYear.Text = reader["Year"].ToString();
                TxtContact.Text = reader["ContactNo"].ToString();
                TxtEmail.Text = reader["Email"].ToString();
                if (reader["IsVisitor"].ToString().Equals("1"))
                {
                    ChkVisitor.Checked = true;
                }


                Main.Show();
            }

            dbConnection.Close();
            
            TxtPassword.PasswordChar = '\u25CF';
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text.Trim().Length > 0)
            {
                string sqlCommand = "UPDATE users SET Password = '" + TxtPassword.Text.Trim() + "' WHERE ID = " + LblUserId.Text + " LIMIT 1";

                Helper.DB.ExecuteNonQuery(sqlCommand);
                TxtPassword.Clear();

                MessageBox.Show("Password successfully updated.", "Change Password" ,MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void cmbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbShowPass.Checked)
            {
                TxtPassword.PasswordChar = '\0';
            }
            else
            {
                TxtPassword.PasswordChar = '\u25CF';
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
