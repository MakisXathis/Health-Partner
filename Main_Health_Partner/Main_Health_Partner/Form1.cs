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
        //Food attributes attributes to search by
        String maxCalories = "100", minCalories = "0", minProtein = "0", maxProtein = "100", minFat = "0", maxFat = "100", minCarbs = "0", maxCarbs = "500";

        private void button1_Click_1(object sender, EventArgs e)
        {
            RESTClient rClient = new RESTClient();

            rClient.endPoint = "https://spoonacular-recipe-food-nutrition-v1.p.mashape.com/food/products/search?query=" + textBoxSearch.Text + "&offset=0&number=10&maxCalories=" + textBoxMaxCalories.Text + "&minProtein=" + textBoxMinProtein.Text + "&maxProtein=" + textBoxMaxProtein.Text+ "&minFat=" + textBoxMinFat.Text + "&maxFat=" + textBoxMaxFat.Text + "&minCarbs=" + textBoxMinCarbs.Text + "&maxCarbs=" + textBoxMaxCarbs.Text + "&minCalories=" + textBoxMinCalories.Text;

            f = rClient.makeFoodRequest();
            dataGridViewFood.RowTemplate.Height = 150;
            dataGridViewFood.Rows.Clear();
            dataGridViewFood.Refresh();
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
            dataGridViewSessure.Rows.Clear();
            dataGridViewSessure.Refresh();
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
            getRecipeInfo = String.Join(",",ri.getIngredients().ToArray());
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
            RESTClient rClient = new RESTClient();
            rClient.endPoint = "https://spoonacular-recipe-food-nutrition-v1.p.mashape.com/recipes/search?diet=" + listBoxDiet.GetItemText(listBoxDiet.SelectedItem) + "&excludeIngredients=" + textBoxExIngredients.Text + "&intolerances=" + textBoxIntolarences.Text + "&number=10&offset=0&query=" + textBoxRecipe.Text + "&type=" + listBoxType.GetItemText(listBoxType.SelectedItem);

            Recipe[] re = rClient.makeRecipeRequest();
            dataGridViewRecipe.Rows.Clear();
            dataGridViewRecipe.Refresh();
            for (int i = 0; i < 10; i++)
            {              
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewRecipe);
                row.Cells[0].Value = re[i].getId();
                row.Cells[1].Value = re[i].getName();
                row.Cells[2].Value = re[i].getMinutes();
                row.Cells[3].Value = re[i].getServings();

                dataGridViewRecipe.Rows.Add(row);
            }
            int RowIndex = dataGridViewSessure.RowCount - 1;
            DataGridViewRow R = dataGridViewSessure.Rows[RowIndex];
        }

        private void dataGridViewRecipe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridViewRecipe.CurrentCell.RowIndex;
            int columnindex = dataGridViewRecipe.CurrentCell.ColumnIndex;
            RESTClient rClient = new RESTClient();
            rClient.endPoint = "https://spoonacular-recipe-food-nutrition-v1.p.mashape.com/recipes/" + dataGridViewRecipe.Rows[rowindex].Cells[columnindex].Value.ToString() + "/information";

            RecipeInfo ri = rClient.makeRecipeInformationRequest();
            Info_Recipe ir = new Info_Recipe();
            ir.ShowDialog();
            getRecipeInfo = String.Join(",", ri.getIngredients().ToArray());
            getRecipesteps = ri.getSteps().ToString();

        }

        private void buttonSaveSessure_Click(object sender, EventArgs e)
        {
            string StrQuery;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kostas\Documents\GitHub\Health-Partner\MyDatabase.mdf;Integrated Security=True");

            for (int i = 0; i < dataGridViewSessure.Rows.Count - 1; i++)
            {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.program (Id , day , food) VALUES ('"+Int32.Parse(dataGridViewSessure.Rows[i].Cells[0].Value.ToString())+"',' "+ dataGridViewSessure.Rows[i].Cells[1].Value.ToString()+"','"+ dataGridViewSessure.Rows[i].Cells[2].Value.ToString()+"')",conn);            
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();        
            }
                        
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textBoxName.Enabled = true;
            textBoxAge.Enabled = true;
            textBoxSurname.Enabled = true;
            textBoxWeight.Enabled = true;
            textBoxHeight.Enabled = true;
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kostas\Documents\GitHub\Health-Partner\MyDatabase.mdf;Integrated Security=True"))
            {

                SqlCommand CmdSql = new SqlCommand("UPDATE dbo.myusers SET name=@name, surname = @surname, age = @age, weight= @weight , height = @height WHERE username like '" + Login.recby + "%' and password like '%" + Login.recby2 + "%'", conn);

                CmdSql.Parameters.AddWithValue("@name", textBoxName.Text.ToString());
                CmdSql.Parameters.AddWithValue("@surname", textBoxSurname.Text.ToString());
                CmdSql.Parameters.AddWithValue("@age", Convert.ToInt32(textBoxAge.Text));
                CmdSql.Parameters.AddWithValue("@weight", Convert.ToInt32(textBoxWeight.Text));
                CmdSql.Parameters.AddWithValue("@height", Convert.ToSingle(textBoxHeight.Text));
                conn.Open();
                try
                {
                    CmdSql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    conn.Close();
                }
            }
            textBoxName.Enabled = false;
            textBoxAge.Enabled = false;
            textBoxSurname.Enabled = false;
            textBoxWeight.Enabled = false;
            textBoxHeight.Enabled = false;
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
            using (SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kostas\Documents\GitHub\Health-Partner\MyDatabase.mdf;Integrated Security=True"))
            {
                c.Open();
                using (SqlDataAdapter a = new SqlDataAdapter("select * from dbo.myusers where username like '%"+Login.recby+"%' and password like '%"+Login.recby2+"%'", c))
                {
                    DataTable t = new DataTable();
                    a.Fill(t);
                    dataGridView1.DataSource = t;
                }
            }
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            filldata();
            this.myusersTableAdapter.Fill(this.myDatabaseMyUsers.myusers);
            string s = Login.recby;
            dataGridView1.Visible = false;
            //string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kostas\source\repos\Health-Partner\Main_Health_Partner\MyDatabase.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kostas\Documents\GitHub\Health-Partner\MyDatabase.mdf;Integrated Security=True");

            string selectSql = "select @name,@surname,@weight,@age,@height from dbo.myusers where @username='%"+s+"%'";
            SqlCommand com = new SqlCommand(selectSql, con);

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
