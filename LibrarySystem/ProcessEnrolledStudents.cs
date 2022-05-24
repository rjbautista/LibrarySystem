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
    public partial class ProcessEnrolledStudents : UserControl
    {
        public ProcessEnrolledStudents()
        {
            InitializeComponent();
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {

            string UsnNumbers = TxtUsnNumber.Text.Trim();
            if (!UsnNumbers.Equals(""))
            {
                DialogResult Result = MessageBox.Show("Are you sure proceed with updating the Enrolled USN numbers?", "Confirm", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    TxtLog.Text = "Starting process...\n";
                    // update all students and set IsEnrolled to false;
                    string SqlCommand = "UPDATE users SET IsEnrolled = 0, Role = 'Student'";
                    Helper.DB.ExecuteNonQuery(SqlCommand);
                    TxtLog.Text += "All students has been updated and set to not Enrolled.\n";

                    Array Usns = UsnNumbers.Split(',');
                    foreach (string Usn in Usns)
                    {
                        if (!Usn.Equals(""))
                        {
                            TxtLog.Text += "Updating user with USN:'" + Usn + "' as Enrolled.\n";
                            SqlCommand = "UPDATE users SET IsEnrolled = 1 WHERE USN = '" + Usn + "' AND Role = 'Student' LIMIT 1";
                            Helper.DB.ExecuteNonQuery(SqlCommand);
                        }
                    }
                    TxtLog.Text += "Completed!\n";
                }
            }
        }
    }
}
