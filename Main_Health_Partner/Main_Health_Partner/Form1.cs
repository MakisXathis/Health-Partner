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
        void filldata()
        {
            using (SqlConnection c = new SqlConnection(Properties.Settings.Default.MyDatabaseConnectionString))
            {
                c.Open();
                using (SqlDataAdapter a = new SqlDataAdapter("select * from dbo.myusers where username like '"+Login.recby.Trim()+"'", c))
                {
                    DataTable t = new DataTable();
                    a.Fill(t);
                    dataGridView1.DataSource = t;
                }
            }
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabaseMyUsers.myusers' table. You can move, or remove it, as needed.
            filldata();
            this.myusersTableAdapter.Fill(this.myDatabaseMyUsers.myusers);
            string s = Login.recby;
            dataGridView1.Visible = false;
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MyDatabase.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            string selectSql = "select @name,@surname,@weight,@age,@height from dbo.myusers where @username='" + s+"'";
            SqlCommand com = new SqlCommand(selectSql, con);
            // SqlCommand myCommand = new SqlCommand("select * from dbo.myusers where username='" + s + "'", con1);

            textBoxName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxSurname.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxAge.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxWeight.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxHeight.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //myReader = myCommand.ExecuteReader();                    


        }
    }
}
