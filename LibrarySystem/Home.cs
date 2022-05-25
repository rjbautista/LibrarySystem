using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToString("D");

            RefreshList();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToString("D");
        }
        private void displayNumofBooks()
        {
            if (!this.DesignMode)
            {
                MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
              
                DataTable sum = new DataTable();
                string sqlCommand = "SELECT TotalQty FROM bookheaders WHERE Status= 'active'";

                MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
                dbConnection.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(sum);
                int total = 0;
                for (int num = 0; num < sum.Rows.Count; ++num)
                {
                    total += Convert.ToInt32(sum.Rows[num][0].ToString());
                }
                string c = Convert.ToString(total);
                numBooks.Text = c;
                dbConnection.Close();
            }
        }

        private void displayNumofBBooks()
        {
            if (!this.DesignMode)
            {
                MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
         
                DataTable sum = new DataTable();
                string sqlCommand = "SELECT COUNT(*) FROM booktxndetails WHERE BorrowDate IS NOT NULL AND ReturnDate IS NULL";
                MySqlCommand command = new MySqlCommand(sqlCommand, dbConnection);
                dbConnection.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(sum);
                int total = 0;
                for (int num = 0; num < sum.Rows.Count; ++num)
                {
                    total += Convert.ToInt32(sum.Rows[num][0].ToString());
                }
                string c = Convert.ToString(total);
                NumBBooks.Text = c;
                dbConnection.Close();
            }
        }

        private void displayNumofUsers()
        {
            if (!this.DesignMode)
            {
                MySqlConnection dbConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                string memberProfessor = "SELECT COUNT(*) FROM users WHERE Position= 'PROFESSOR' AND Status = 'active'";
                string memberStudent = "SELECT COUNT(*) FROM users WHERE Position= 'STUDENT' AND Status = 'active'";
                MySqlCommand command = new MySqlCommand(memberProfessor, dbConnection);
                MySqlCommand dcommand = new MySqlCommand(memberStudent, dbConnection);
                dbConnection.Open();
                Int32 countProf = Convert.ToInt32(command.ExecuteScalar());
                Int32 countStd = Convert.ToInt32(dcommand.ExecuteScalar());
                Int32 total = countStd + countProf;
                string totalMembers = Convert.ToString(total);
                Users.Text = totalMembers;
                dbConnection.Close();
            }
        }

        public void RefreshList()
        {
            displayNumofBooks();
            displayNumofBBooks();
            displayNumofUsers();
        }



        }
}
