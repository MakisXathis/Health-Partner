using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace Main_Health_Partner
{
    
    public partial class Login : Form
    {
        string connectionString;
        public Login()
        {
            InitializeComponent();          
                
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
            
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MyDatabase.mdf;Integrated Security=True");
            string user = textBoxUsername.Text;
            string passwd = textBoxPassword.Text;
            
            using (SqlCommand Strquer = new SqlCommand("select * from dbo.users where @username = '" + user + "' and @password = '" + passwd+"'", sql))
            {
                try
                {
                    sql.Open();
                }
                catch (SqlException Ex)
                {
                    MessageBox.Show("exception catched");
                }
                Strquer.Parameters.AddWithValue("@username", user);
                Strquer.Parameters.AddWithValue("@password", passwd);
                SqlDataReader dr = Strquer.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("sql works");
                    this.Hide();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Wrong Username/Password", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
                
            
        }
        public void Dispose()
        {
            Dispose(true);

            // Use SupressFinalize in case a subclass
            // of this type implements a finalizer.
            GC.SuppressFinalize(this);
        }

        private void buttonNewAccount_Click(object sender, EventArgs e)
        {
            Sign_In_Form sif = new Sign_In_Form();
            sif.ShowDialog();
        }
    }
}
