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
    public partial class Form_Main : Form
    {
        //Food attributes attributes to search by
        String maxCalories = "100", minCalories = "0", minProtein = "0", maxProtein = "100", minFat = "0", maxFat = "100", minCarbs = "0", maxCarbs = "500";

        private void button1_Click_1(object sender, EventArgs e)
        {
            RESTClient rClient = new RESTClient();

            rClient.endPoint = "https://spoonacular-recipe-food-nutrition-v1.p.mashape.com/food/products/search?query=" + textBoxSearch.Text + "&offset=0&number=10&maxCalories=" + textBoxMaxCalories.Text + "&minProtein=" + textBoxMinProtein.Text + "&maxProtein=" + textBoxMaxProtein.Text+ "&minFat=" + textBoxMinFat.Text + "&maxFat=" + textBoxMaxFat.Text + "&minCarbs=" + textBoxMinCarbs.Text + "&maxCarbs=" + textBoxMaxCarbs.Text + "&minCalories=" + textBoxMinCalories.Text;

            f = rClient.makeFoodRequest();
            dataGridViewFood.RowTemplate.Height = 150;          
            
            for (int i = 0; i < f.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewFood);
                row.Cells[0].Value = f[i].getId();
                row.Cells[1].Value = f[i].getName();
                row.Cells[2].Value = f[i].getImg();
                
                dataGridViewFood.Rows.Add(row);
            }
            int RowIndex = dataGridViewFood.RowCount - 1;
            DataGridViewRow R = dataGridViewFood.Rows[RowIndex];
        }

        private void tabPageRecipe_Click(object sender, EventArgs e)
        {

        }
        Dictionary<int,WeekMeal> meal;
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            RESTClient rClient = new RESTClient();
            rClient.endPoint = " https://spoonacular-recipe-food-nutrition-v1.p.mashape.com/recipes/mealplans/generate?timeFrame=" + timeFrame + "&targetCalories=" + targetCalories ;
            meal = rClient.makeMealRequest();

            for (int i = 0; i <21; i++)
            {
                meal[i].ToString();
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewSessure);
                row.Cells[0].Value = meal[i].getId();
                row.Cells[1].Value = meal[i].getDay();
                row.Cells[2].Value = meal[i].getName();
                dataGridViewSessure.Rows.Add(row);
            }
            int RowIndex = dataGridViewSessure.RowCount - 1;
            DataGridViewRow R = dataGridViewSessure.Rows[RowIndex];
        }
        
        private void dataGridViewSessure_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RESTClient rClient = new RESTClient();
            int rowindex = dataGridViewSessure.CurrentCell.RowIndex;
            int columnindex = dataGridViewSessure.CurrentCell.ColumnIndex;
         
            rClient.endPoint = "https://spoonacular-recipe-food-nutrition-v1.p.mashape.com/recipes/" + dataGridViewSessure.Rows[rowindex].Cells[columnindex].Value.ToString()+ "/information"; 
            RecipeInfo ri = rClient.makeRecipeInformationRequest();
            Info_Recipe ir = new Info_Recipe();
            ir.ShowDialog();
            getRecipeInfo = ri.getIngredients().ToString();
            getRecipesteps = ri.getSteps().ToString();
        }
        public static string recipeingredients;
        public static string recipesteps;
        public static string getRecipeInfo
        {

            get { return recipeingredients; }
            set { recipeingredients = value; }
        }
        public static string getRecipesteps
        {

            get { return recipesteps; }
            set { recipesteps = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Meal Plan attributes to search by
        String timeFrame = "week", targetCalories = "3000", diet;

        //Results from foodsearch
        Food[] f;



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

        private void button1_Click(object sender, EventArgs e)
        {
            RESTClient rClient = new RESTClient();

            rClient.endPoint = "https://spoonacular-recipe-food-nutrition-v1.p.mashape.com/food/products/search?query=" + textBoxSearch.Text + "&offset=0&number=10&maxCalories=" + maxCalories + "&minProtein=" + minProtein + "&maxProtein=" + maxProtein + "&minFat=" + minFat + "&maxFat=" + maxFat + "&minCarbs=" + minCarbs + "&maxCarbs=" + maxCarbs + "&minCalories=" + minCalories;

            f = rClient.makeFoodRequest();

            for(int i = 0 ; i < 10 ; i++) {
                Console.WriteLine(f[i].toString());
            }
            
        }
    }
}
