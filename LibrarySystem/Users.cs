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
using System.Text.RegularExpressions;
using ZXing.Common;
using ZXing;
using ZXing.QrCode;
using System.IO;

namespace LibrarySystem
{
    public partial class Users : UserControl
    {
        private Boolean IsEditing = false;
        private string EditingId = "";

        public Users()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidForm())
            {

                string Name = TxtName.Text.Trim();
                string Usn = TxtUsn.Text.Trim();
                string Role = cmbRole.SelectedItem.ToString();
                string Gender = cmbGender.SelectedItem.ToString();
                string Position = CmbPosition.SelectedItem.ToString();
                string Course = CmbCourse.SelectedItem.ToString();
                string Year = TxtYear.Text.Trim();
                string Contact = TxtContact.Text.Trim();
                string Email = TxtEmail.Text.Trim();
                string Password = TxtPassword.Text.Trim();
                int IsVisitor = ChkVisitor.Checked ? 1 : 0;
                int IsEnrolled = ChkEnrolled.Checked ? 1 : 0;
                string Status = CmbStatus.SelectedItem.ToString();
                
                string sqlCommand = "INSERT INTO users " +
                    "(USN, Name, Role, Gender, Position, Course, Year, ContactNo, Email, Password, Status, IsVisitor, IsEnrolled) VALUES " +
                    "('" + Usn + "', '" + Name + "', '" + Role + "', '" + Gender + "', '" + Position + "', '" + Course + "', '" + Year + "', '" + Contact + "', '" + Email + "', '" + Password + "', 'active', " + IsVisitor + ", " + IsEnrolled + ")";

                if (IsEditing)
                {
                    sqlCommand = "UPDATE users SET "
                        + "USN='" + Usn + "',"
                        + "Name = '" + Name + "',"
                        + "Role = '" + Role + "',"
                        + "Gender = '" + Gender + "',"
                        + "Position = '" + Position + "',"
                        + "Course = '" + Course + "',"
                        + "Year = '" + Year + "',"
                        + "ContactNo = '" + Contact + "',"
                        + "Email = '" + Email + "',"
                        + "Status = '" + Status + "',"
                        + "IsVisitor = '" + IsVisitor + "',"
                        + "IsEnrolled = '" + IsEnrolled + "'";

                    if (Password.Length > 0)
                    {
                        sqlCommand += ",Password = '" + Password + "'";
                    }
                    sqlCommand += " WHERE ID = " + EditingId + " LIMIT 1";
                    GrpNewForm.Visible = false;
                    this.clearForm();
                }

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
                IsEditing = false;
                EditingId = "";
                this.RefreshGrid();

                BtnNew.Enabled = true;
                BtnEdit.Enabled = true;
                BtnDelete.Enabled = true;
                GridUsers.Enabled = true;
                GrpNewForm.Visible = false;

            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.RefreshGrid();
                this.loadCourses();
                GridUsers.ClearSelection();
                TxtPassword.PasswordChar = '\u25CF';
                cmbRole.SelectedIndex = 0;
                cmbGender.SelectedIndex = 0;
                CmbPosition.SelectedIndex = 0;
                CmbCourse.SelectedIndex = 0;
                CmbStatus.SelectedIndex = 0;
                CmbFilter.SelectedItem = "Name";
            }
        }

        public void RefreshGrid(string SearchKey = "")
        {
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            string sqlCommand = "SELECT ID, USN, Name, Role, Gender, Position, Course, Year, ContactNo, Email, Status, IsEnrolled, IsVisitor FROM users";
            if (!SearchKey.Equals(""))
            {
                string FilterField = CmbFilter.SelectedItem.ToString();
                sqlCommand += " WHERE " + FilterField + " LIKE '%" + SearchKey + "%'";
            }

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            GridUsers.DataSource = ds.Tables[0];
            dbConnection.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            GrpNewForm.Visible = true;
            BtnNew.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            GridUsers.Enabled = false;
            this.clearForm();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            GrpNewForm.Visible = false;
            IsEditing = false;
            EditingId = "";

            BtnNew.Enabled = true;
            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            GridUsers.Enabled = true;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            RefreshGrid(TxtSearch.Text.Trim());
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (GridUsers.SelectedRows.Count > 0)
            {
                IsEditing = true;
                DataGridViewRow row = GridUsers.SelectedRows[0];
                EditingId = row.Cells[0].Value.ToString();

                MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                string sqlCommand = "SELECT * FROM users WHERE ID='" + EditingId + "'";

                MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
                dbConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();

                    TxtUsn.Text = reader["USN"].ToString();
                    TxtName.Text = reader["Name"].ToString();
                    cmbRole.SelectedItem = reader["Role"].ToString();
                    cmbGender.SelectedItem = reader["Gender"].ToString();
                    CmbPosition.SelectedItem = reader["Position"].ToString();
                    CmbCourse.SelectedItem = reader["Course"].ToString();
                    TxtYear.Text = reader["Year"].ToString();
                    TxtContact.Text = reader["ContactNo"].ToString();
                    TxtEmail.Text = reader["Email"].ToString();
                    CmbStatus.SelectedItem = reader["Status"].ToString();
                    ChkVisitor.Checked = (bool)reader["IsVisitor"];
                    ChkVisitor.Checked = (bool)reader["IsEnrolled"];

                    string QrPath = reader["QR"].ToString();
                    if (!QrPath.Equals(""))
                    {
                        // lod qr to image.
                        PicQr.Image = Image.FromFile(QrPath);
                    }

                    GrpNewForm.Visible = true;
                }
                dbConnection.Close();
            }
            BtnNew.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            GridUsers.Enabled = false;
        }

        private void GridBookCategory_SelectionChanged(object sender, EventArgs e)
        {

            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            BtnQr.Enabled = true;

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GridUsers.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to deactivate this user?", "Confirm status update", MessageBoxButtons.YesNo);
                if (dialogResult.Equals(DialogResult.Yes)) {
                    DataGridViewRow row = GridUsers.SelectedRows[0];
                    string Id = row.Cells[0].Value.ToString();
                    Helper.DB.ExecuteNonQuery("UPDATE users SET status='deactivated' WHERE ID = '" + Id + "' LIMIT 1");
                    this.RefreshGrid();
                }
            }
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSearch.PerformClick();
            }
        }
        
        private Boolean ValidForm()
        {
            Boolean isValid = false;

            string Name = TxtName.Text.Trim();
            string Usn = TxtUsn.Text.Trim();
            string Role = cmbRole.SelectedItem.ToString();
            string Contact = TxtContact.Text.Trim();
            string Email = TxtEmail.Text.Trim();
            string Password = TxtPassword.Text.Trim();


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

            if (!IsEditing)
            {
                if (cmbRole.SelectedItem.ToString() != "Student" && Password.Length < 1)
                {
                    MessageBox.Show("Please enter a password.", "Account Information", MessageBoxButtons.OK);
                    TxtPassword.Focus();
                    return isValid;
                }
            }

            isValid = true;

            return isValid;
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

        private void loadCourses()
        {
            MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string sqlCommand = "SELECT * FROM courses";

            MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
            dbConnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    CmbCourse.Items.Add(reader["Name"].ToString());
                }
            }
            dbConnection.Close();
        }

        private void clearForm() {
            TxtUsn.Clear();
            TxtName.Clear();
            cmbRole.SelectedIndex = 0;
            cmbGender.SelectedIndex = 0;
            CmbPosition.SelectedIndex = 0;
            CmbCourse.SelectedIndex = 0;
            TxtYear.Clear();
            TxtContact.Clear();
            TxtEmail.Clear();
            TxtPassword.Clear();
            CmbStatus.SelectedIndex = 0;
            ChkVisitor.Checked = false;
            ChkEnrolled.Checked = false;
        }

        private void TxtUsn_Leave(object sender, EventArgs e)
        {
            this.GenerateQR(TxtUsn.Text, EditingId);
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

        private void BtnQr_Click(object sender, EventArgs e)
        {
            if (GridUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridUsers.SelectedRows[0];
                string UserId = row.Cells[0].Value.ToString();
                string UserUsn = row.Cells[1].Value.ToString();

                Form PrintQr = new PrintQr();

                Control LblUserId = PrintQr.Controls.Find("LblUserId", true)[0];
                LblUserId.Text = UserId;

                this.GenerateQR(UserUsn, UserId);

                PrintQr.Show();
            }
        }
    }
}
