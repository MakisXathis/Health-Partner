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
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            
            string user = textBoxUsername.Text;
            string passwd = textBoxPassword.Text;
            if (!((textBoxUsername.Text.CompareTo("") | (textBoxPassword.Text.CompareTo(""))) == 0))
            {
                using (SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kostas\source\repos\Health-Partner\Main_Health_Partner\Main_Health_Partner\MyDatabase.mdf;Integrated Security=True"))
                {
                    try
                    {
                        sql.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.myusers " +
                                            "WHERE username like '%"+user+"%' and password like '%"+passwd+"%'", sql);
                        cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                        cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                        int result = (int)cmd.ExecuteScalar();
                        if (result > 1)
                        {
                            recby = user;
                            sql.Close();

                            this.Hide();
                            this.Dispose();

                        }
                        else
                        {
                            MessageBox.Show("Incorrect login");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Wrong Username/Password:");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all the textboxes");
            }
        }
                
        private void buttonNewAccount_Click(object sender, EventArgs e)
        {
            Sign_In_Form sif = new Sign_In_Form();
            sif.ShowDialog();
        }
    }
}
