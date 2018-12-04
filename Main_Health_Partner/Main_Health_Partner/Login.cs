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
        public static string username;
        public static string password;
        public Login()
        {
            InitializeComponent();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();

        }
        public static string recby
        {

            get { return username; }
            set { username = value; }
        }
        public static string recby2
        {

            get { return password; }
            set { password = value; }
        }
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            
            string user = textBoxUsername.Text;
            string passwd = textBoxPassword.Text;
            
                using (SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestBase.mdf;Integrated Security=True"))
                {
                    try
                    {
                        sql.Open();
                        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.myusers " +
                                            "WHERE username like '%"+user+ "%' and password like '%" + passwd + "%'", sql);
                        cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                        cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                        int result = (int)cmd.ExecuteScalar();
                        if (result == 1)
                        {
                            recby = user;
                            recby2 = passwd;
                            sql.Close();

                            this.Hide();
                            this.Dispose();

                        }
                        else
                        {
                            MessageBox.Show("Wrong username/password");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            
            
        }
                
        private void buttonNewAccount_Click(object sender, EventArgs e)
        {
            Sign_In_Form sif = new Sign_In_Form();
            sif.ShowDialog();
        }
    }
}
