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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
           
            InitializeComponent();
            Application.EnableVisualStyles();      
            Login login = new Login();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.ShowDialog();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            About ab = new About();
            
            ab.ShowDialog();
        }
    }
}
