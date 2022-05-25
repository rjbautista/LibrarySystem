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
    public partial class IRForm : KryptonForm
    {
        string EditingId = "";
        bool IsEditing = false;

        public IRForm()
        {
            InitializeComponent();
        }

        private void IRForm_Load(object sender, EventArgs e)
        {
            TxtTitle.Text = "Incident Report #" + LblIrNumber.Text + " - " + LblUsn.Text + ":" + LblName.Text;

            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string sqlCommand = "SELECT * FROM incidents WHERE BookTxnHeaderId='" + LblTxnNo.Text + "'";

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                IsEditing = true;
                EditingId = reader["ID"].ToString();

                TxtTitle.Text = reader["Title"].ToString();
                TxtDetails.Text = reader["Description"].ToString();
            }

            dbConnection.Close();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!TxtDetails.Text.Trim().Equals(""))
            {
                string StudentId = LblStudentId.Text;
                string IrNo = LblIrNumber.Text;
                string Title = TxtTitle.Text;
                string Description = TxtDetails.Text.Trim();
                string TxnId = LblTxnNo.Text;


                Form Main = Application.OpenForms["Main"];
                Control LblUserId = Main.Controls.Find("LblUserId", true)[0];
                string UserId = LblUserId.Text;

                string SqlCommand = "";
                if (!IsEditing)
                {
                    SqlCommand = "INSERT INTO incidents (IRNo ,Title ,Description ,UserId ,StudentId ,BookTxnHeaderId) VALUES (" +
                        "'" + IrNo + "', '" + Title + "', '" + Description + "', '" + UserId + "', '" + StudentId + "', '" + TxnId + "')";
                } else
                {
                    SqlCommand = "UPDATE incidents SET Description='" + TxtDetails.Text.Trim() + "' WHERE ID='" + EditingId + "'";
                }

                Helper.DB.ExecuteNonQuery(SqlCommand);
                MessageBox.Show("Incident report has been saved.");
                this.Close();
            }else
            {
                MessageBox.Show("Please enter incident details.");
            }
        }
    }
}
