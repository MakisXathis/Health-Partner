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

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (((textBoxUsername.Text.CompareTo("1")) > 1) & ((textBoxPassword.Text.CompareTo("1")) > 1))
            {
                Form_Main main = new Form_Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username/Password", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
            this.Close();
        }

        private void buttonNewAccount_Click(object sender, EventArgs e)
        {
            Sign_In_Form sif = new Sign_In_Form();
            sif.ShowDialog();
        }
    }
}
