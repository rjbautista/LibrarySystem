using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
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
    public partial class QrScanner : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        public QrScanner()
        {
            InitializeComponent();
        }

        private void QrScanner_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                cboCamera.Items.Add(Device.Name);
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
            BtnStart.PerformClick();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
            timer1.Start();
            videoCaptureDevice.Start();
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QrScanner_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (videoCaptureDevice.IsRunning == true) {
                videoCaptureDevice.Stop();
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader Reader = new BarcodeReader();
                Result result = Reader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    txtResult.Text = result.ToString();

                    MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                    string sqlCommand = "SELECT * FROM users WHERE USN='" + txtResult.Text + "' LIMIT 1";
                    MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
                    dbConnection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();

                        string UserID = reader["ID"].ToString();
                        string Status = reader["Status"].ToString();
                        string Name = reader["Name"].ToString();
                        bool IsEnrolled = (bool)reader["IsEnrolled"];

                        if (!Status.Equals("active"))
                        {
                            MessageBox.Show("User is not active.");
                        }
                        else if (IsEnrolled == false)
                        {
                            MessageBox.Show("User is not enrolled.");
                        }
                        else
                        {
                            DialogResult Result = MessageBox.Show("Hi " + Name + ", we will be sending this book request to the librarian.\n Do you want to proceed?.", "Book Request", MessageBoxButtons.YesNo);
                            if (Result == DialogResult.Yes)
                            {
                                Form Kiosk = Application.OpenForms["Kiosk"];
                                Control TxtUserId = Kiosk.Controls.Find("TxtUserId", true)[0];
                                TxtUserId.Text = UserID;

                                Button BtnSendRequest = Kiosk.Controls.Find("BtnSendRequest", true).FirstOrDefault() as Button;
                                BtnSendRequest.PerformClick();
                                this.Close();
                            }
                        }

                    } else
                    {
                        MessageBox.Show("Invalid Code.");
                    }

                    dbConnection.Close();

                }
            }
        }
    }
}
