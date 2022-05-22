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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void btnKiosk_Click(object sender, EventArgs e)
        {
            Form Kiosk = new Kiosk();
            Kiosk.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form Login = new Login();
            Login.Show();
        }
    }
}
