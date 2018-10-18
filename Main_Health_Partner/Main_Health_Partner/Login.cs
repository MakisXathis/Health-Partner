using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Health_Partner
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public bool check()
        {
            bool p = false;
            if ((textBoxUsername.Text == "1") & (textBoxPassword.Text == "1")) {
                return true;
            }
            return p;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
