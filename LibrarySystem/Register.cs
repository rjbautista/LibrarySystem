using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using ZXing.Common;
using ZXing;
using ZXing.QrCode;


namespace LibrarySystem
{
    public partial class Register : KryptonForm
    {
        public Register()
        {
            InitializeComponent();
        }
        private Boolean IsEditing = false;
        private string EditingId = "";
        private void TxtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        private void ChkVisitor_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVisitor.Checked)
            {
                ChkEnrolled.CheckState = CheckState.Unchecked;
            }


        }

        private void ChkEnrolled_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkEnrolled.Checked)
            {
                ChkVisitor.CheckState = CheckState.Unchecked;
            }

        }

        private void cmbShowPass_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidForm())
            {
                string Name = TxtName.Text.Trim();
                string Usn = TxtUsn.Text.Trim();
                string Role = cmbRole.SelectedItem.ToString();
                string Gender = cmbGender.SelectedItem.ToString();
                string Position = cmbRole.SelectedItem.ToString();
                string Course = CmbCourse.SelectedItem.ToString();
                string Year = TxtYear.Text.Trim();
                string Contact = TxtContact.Text.Trim();
                string Email = TxtEmail.Text.Trim();
                int IsVisitor = ChkVisitor.Checked ? 1 : 0;
                int IsEnrolled = ChkEnrolled.Checked ? 1 : 0;

                string sqlCommand = "INSERT INTO users " +
                    "(USN, Name, Role, Gender, Position, Course, Year, ContactNo, Email, Status, IsVisitor, IsEnrolled) VALUES " +
                    "('" + Usn + "', '" + Name + "', '" + Role + "', '" + Gender + "', '" + Position + "', '" + Course + "', '" + Year + "', '" + Contact + "', '" + Email + "', 'active', " + IsVisitor + ", " + IsEnrolled + ")";

                MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                dbConnection.Open();
                MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
                command.ExecuteNonQuery();
                string insertedId = command.LastInsertedId.ToString();

                if (IsEditing)
                {
                    insertedId = EditingId;
                }
              

                // generate Qr code.
                this.GenerateQR(Usn, insertedId);

                dbConnection.Close();

                TxtName.Clear();

                this.clearForm();
            }



        }

     
        public string GenerateQR(string Usn, string UserId)
        {

            PicQr.InitialImage = null;
            if (PicQr.Image != null)
            {
                PicQr.Image.Dispose();
                PicQr.Image = null;
            }
            string QrPath = "";
            QrCodeEncodingOptions options = new QrCodeEncodingOptions();
            options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 1000,
                Height = 1000,
            };
            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;

            if (String.IsNullOrWhiteSpace(Usn) || String.IsNullOrEmpty(Usn))
            {
                PicQr.Image = null;
            }
            else
            {
                var qr = new ZXing.BarcodeWriter();
                qr.Options = options;
                qr.Format = ZXing.BarcodeFormat.QR_CODE;
                var result = new Bitmap(qr.Write(Usn.Trim()));
                PicQr.Image = result;

                if (!Directory.Exists("qr"))
                {
                    Directory.CreateDirectory("qr");
                }
                QrPath = "qr/" + UserId + ".jpg";

                PicQr.Image.Save(QrPath, System.Drawing.Imaging.ImageFormat.Jpeg);


                if (!QrPath.Equals(""))
                {
                    string sqlCommand = "UPDATE users SET QR='" + QrPath + "' WHERE ID='" + UserId + "' LIMIT 1";
                    Helper.DB.ExecuteNonQuery(sqlCommand);
                }
            }
            return QrPath;
        }

        private Boolean ValidForm()
        {
            Boolean isValid = false;

            string Name = TxtName.Text.Trim();
            string Usn = TxtUsn.Text.Trim();
            string Role = cmbRole.SelectedItem.ToString();
            string Contact = TxtContact.Text.Trim();
            string Email = TxtEmail.Text.Trim();


            if (Name.Length < 1)
            {
                MessageBox.Show("Please enter a valid name.", "Account Information", MessageBoxButtons.OK);
                TxtName.Focus();
                return isValid;
            }

            if (Usn.Length < 1)
            {
                MessageBox.Show("Please enter a valid USN.", "Account Information", MessageBoxButtons.OK);
                TxtUsn.Focus();
                return isValid;
            }

            // Check USN.
            bool UsnExist = false;
            if (IsEditing)
            {
                UsnExist = Model.User.ExistingUsn(Usn, EditingId);
            }
            else
            {
                UsnExist = Model.User.ExistingUsn(Usn);
            }

            if (UsnExist)
            {
                MessageBox.Show("Entered USN is already in used.", "Invalid USN", MessageBoxButtons.OK);
                TxtUsn.Focus();
                return isValid;
            }


            if (Role.Length < 1)
            {
                MessageBox.Show("Please select a role.", "Account Information", MessageBoxButtons.OK);
                cmbRole.Focus();
                return isValid;
            }

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(Email);

            if (!Email.Equals("") && !match.Success)
            {
                MessageBox.Show("Please enter a valid Email address.", "Account Information", MessageBoxButtons.OK);
                TxtEmail.Focus();
                return isValid;
            }

            if (Contact.Length < 1)
            {
                MessageBox.Show("Please enter a valid Contact number.", "Account Information", MessageBoxButtons.OK);
                TxtContact.Focus();
                return isValid;
            }



            isValid = true;

            return isValid;
        }
        private void loadCourses()
        {
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string sqlCommand = "SELECT * FROM courses";

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CmbCourse.Items.Add(reader["Name"].ToString());
                }
            }
            dbConnection.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.loadCourses();
            cmbRole.SelectedIndex = 0;
            cmbGender.SelectedIndex = 0;
            CmbCourse.SelectedIndex = 0;
        

        }
        private void clearForm()
        {
            TxtUsn.Clear();
            TxtName.Clear();
            cmbRole.SelectedIndex = 0;
            cmbGender.SelectedIndex = 0;
        
            CmbCourse.SelectedIndex = 0;
            TxtYear.Clear();
            TxtContact.Clear();
            TxtEmail.Clear();
     
   
            ChkVisitor.Checked = false;
            ChkEnrolled.Checked = false;
        }

    }
}
