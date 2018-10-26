﻿using System;
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
    public partial class Sign_In_Form : Form
    {
        public Sign_In_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MyDatabase.mdf;Integrated Security=True"))
            {
                SqlCommand CmdSql = new SqlCommand("INSERT INTO dbo.myusers (username, password, name, surname, age, weight, height) VALUES (@username, @password, @name, @surname, @age, @weight, @height)", conn);
                conn.Open();
                CmdSql.Parameters.AddWithValue("@username", textBoxUsername.Text);
                CmdSql.Parameters.AddWithValue("@password", textBoxPasswd.Text);
                CmdSql.Parameters.AddWithValue("@name", textBoxName.Text);
                CmdSql.Parameters.AddWithValue("@surname",textBoxSurname.Text);
                CmdSql.Parameters.AddWithValue("@age", Convert.ToInt32(textBoxAge.Text));
                CmdSql.Parameters.AddWithValue("@weight", Convert.ToInt32(textBoxWeight.Text));
                CmdSql.Parameters.AddWithValue("@height", Convert.ToInt32(textBoxHeight.Text));
                CmdSql.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
