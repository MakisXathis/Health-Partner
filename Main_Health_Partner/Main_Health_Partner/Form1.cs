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
        public static int Id_Shedule;
        Dictionary<int,WeekMeal> meal;
        public static int Id_Schedule;
        public static string recipeingredients;
        public static string recipesteps;
        public static string getRecipeInfo

        {

            get { return recipeingredients; }
            set { recipeingredients = value; }
        }

        //Results from food search
        Food[] f;

        //Meal Plan attributes to search by
        String timeFrame = "week", targetCalories = "3000", diet;


        public static string getRecipesteps
        {

            get { return recipesteps; }
            set { recipesteps = value; }
        }

        //The search Button. Calls makeFoodRequest from rClient
        private void buttonSearchFood(object sender, EventArgs e)
        {
            RESTClient rClient = new RESTClient();

            rClient.endPoint = "https://spoonacular-recipe-food-nutrition-v1.p.mashape.com/food/products/search?query=" + textBoxFood.Text + "&offset=0&number=10&maxCalories=" + textBoxMaxCalories.Text + "&minProtein=" + textBoxMinProtein.Text + "&maxProtein=" + textBoxMaxProtein.Text+ "&minFat=" + textBoxMinFat.Text + "&maxFat=" + textBoxMaxFat.Text + "&minCarbs=" + textBoxMinCarbs.Text + "&maxCarbs=" + textBoxMaxCarbs.Text + "&minCalories=" + textBoxMinCalories.Text;
            try{

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

            }catch{
                return;
            }
        }


        //Creates a shedule with the given parameters. Calls the makeMealRequest from rClient
        private void buttonSearchSchedule_Click(object sender, EventArgs e)
        {
            
            RESTClient rClient = new RESTClient();
            rClient.endPoint = " https://spoonacular-recipe-food-nutrition-v1.p.mashape.com/recipes/mealplans/generate?timeFrame=" + timeFrame + "&targetCalories=" + targetCalories ;
            
            try{
                meal = rClient.makeMealRequest();
                dataGridViewSchedule.Rows.Clear();
                dataGridViewSchedule.Refresh();

                for (int i = 0; i <21; i++)
                {
                    
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewSchedule);
                    row.Cells[0].Value = meal[i].getId();
                    row.Cells[1].Value = meal[i].getDay();
                    row.Cells[2].Value = meal[i].getName();
                    dataGridViewSchedule.Rows.Add(row);
                }
                int RowIndex = dataGridViewSchedule.RowCount - 1;
                DataGridViewRow R = dataGridViewSchedule.Rows[RowIndex];
            }catch{
                return;
            }
        }
        //Shows a dialog box with extra information of the given recipe.
        private void dataGridViewSchedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
                RESTClient rClient = new RESTClient();
                int rowindex = dataGridViewSchedule.CurrentCell.RowIndex;
                int columnindex = dataGridViewSchedule.CurrentCell.ColumnIndex;
         
                rClient.endPoint = "https://spoonacular-recipe-food-nutrition-v1.p.mashape.com/recipes/" + dataGridViewSchedule.Rows[rowindex].Cells[columnindex].Value.ToString()+ "/information"; 
                RecipeInfo ri = rClient.makeRecipeInformationRequest();
                Info_Recipe ir = new Info_Recipe();
                ir.ShowDialog();
                getRecipeInfo = String.Join(",", ri.getIngredients().ToArray());
                getRecipesteps = ri.getSteps().ToString();
            }catch{
                return;
            }
        }
        
        //Searches for a recipe given the parameters.
        private void buttonRecipeSearch(object sender, EventArgs e)
        {
            RESTClient rClient = new RESTClient();
            rClient.endPoint = "https://spoonacular-recipe-food-nutrition-v1.p.mashape.com/recipes/search?diet=" + listBoxDiet.GetItemText(listBoxDiet.SelectedItem) + "&excludeIngredients=" + textBoxExIngredients.Text + "&intolerances=" + textBoxIntolarences.Text + "&number=10&offset=0&query=" + textBoxRecipe.Text + "&type=" + listBoxType.GetItemText(listBoxDiet.SelectedItem);
            try{

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
                int RowIndex = dataGridViewRecipe.RowCount - 1;
                DataGridViewRow R = dataGridViewRecipe.Rows[RowIndex];
            }catch{

                dataGridViewRecipe.Rows.Clear();
                dataGridViewRecipe.Refresh();
                
                

            }
        }

        //makes the customer info editable
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textBoxAge.Enabled = true;
            textBoxName.Enabled = true;
            textBoxSurname.Enabled = true;
            textBoxWeight.Enabled = true;
            textBoxHeight.Enabled = true;
        }

        //Updates the database user with the new user information
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestBase.mdf;Integrated Security=True");
            
                SqlCommand cmd = new SqlCommand(@"UPDATE dbo.myusers SET name='" + textBoxName.Text + "', surname='" + textBoxSurname.Text + "', age= "+Int32.Parse(textBoxAge.Text)+", weight= "+Int32.Parse(textBoxWeight.Text)+", height = "+double.Parse(textBoxHeight.Text)+" WHERE username like '"+ Login.recby +"' and password like '"+Login.recby2+"'",c);
                c.Open();
                cmd.ExecuteNonQuery();
                c.Close();
            textBoxAge.Enabled = false;
            textBoxName.Enabled = false;
            textBoxSurname.Enabled = false;
            textBoxWeight.Enabled = false;
            textBoxHeight.Enabled = false;
        }

        //Some extra information about the given recipe
        private void dataGridViewRecipe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            RESTClient rClient = new RESTClient();
            int rowindex = dataGridViewRecipe.CurrentCell.RowIndex;
            int columnindex = dataGridViewRecipe.CurrentCell.ColumnIndex;
            try{

                rClient.endPoint = "https://spoonacular-recipe-food-nutrition-v1.p.mashape.com/recipes/" + dataGridViewRecipe.Rows[rowindex].Cells[columnindex].Value.ToString() + "/information";
                RecipeInfo ri = rClient.makeRecipeInformationRequest();
                Info_Recipe ir = new Info_Recipe();
                ir.ShowDialog();
                getRecipeInfo = String.Join(",", ri.getIngredients().ToArray());
                getRecipesteps = ri.getSteps().ToString();

            }catch{
                return;
            }
        }

        //Saves the current users schedule to the database
        private void buttonSaveSchedule_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestBase.mdf;Integrated Security=True");

            for (int i = 0; i < dataGridViewSchedule.Rows.Count - 1; i++)
            {
                    con.Open();
                    SqlCommand CmdSql = new SqlCommand("INSERT INTO dbo.program (id, day , food , uid) VALUES (@id, @day, @food, @uid)", con);

                    CmdSql.Parameters.AddWithValue("@id", int.Parse(dataGridViewSchedule.Rows[i].Cells[0].Value.ToString()));
                    CmdSql.Parameters.AddWithValue("@day", dataGridViewSchedule.Rows[i].Cells[1].Value.ToString());
                    CmdSql.Parameters.AddWithValue("@food", dataGridViewSchedule.Rows[i].Cells[2].Value.ToString());
                    CmdSql.Parameters.AddWithValue("@uid", int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    CmdSql.ExecuteNonQuery();
                    con.Close();   
            }
        }


        //Loads the users schedule to the database
        private void buttonLoadSchedule_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestBase.mdf;Integrated Security=True";
            dataGridViewSchedule.Rows.Clear();
            dataGridViewSchedule.Columns.Clear();
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT dbo.program.id,dbo.program.day,dbo.program.food FROM dbo.program,dbo.myusers where dbo.program.uid=dbo.myusers.Id and dbo.myusers.username like '" + Login.recby+"'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridViewSchedule.DataSource = dt;
                        }
                    }
                }
            }
        }



        public Form_Main()
        {
           
            InitializeComponent();
            Application.EnableVisualStyles();      
            Login login = new Login();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.ShowDialog();
            returnid();
        }
        
        //Shows the About dialog box
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            About ab = new About();
            
            ab.ShowDialog();
           
        }


        

        void returnid()
        {
            using (SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestBase.mdf;Integrated Security=True"))
            {
               
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestBase.mdf;Integrated Security=True");
                SqlCommand comm = new SqlCommand("select Id from dbo.myusers where username like '"+Login.recby.Trim()+"' and password like '"+Login.recby2+"'", conn);
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                string outputMessage = "";

                while (reader.Read())
                {
                    outputMessage += reader.GetValue(0) + "\n";
                    getId_Schedule = Int32.Parse(reader.GetValue(0).ToString());
                }
                reader.Close();
                conn.Close();
             
            }
        }


        void filldata()
        {
            using (SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestBase.mdf;Integrated Security=True"))
            {
                c.Open();
                using (SqlDataAdapter a = new SqlDataAdapter("select * from dbo.myusers where username like '"+Login.recby+"' and password like '"+Login.recby2+"'", c))
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
            this.myusersTableAdapter1.Fill(this.testBaseDataSet1.myusers);
            //myusersTableAdapter.Fill(this.testBaseDataSet1.myusers);
            string s = Login.recby;
            dataGridView1.Visible = false;
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestBase.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            string selectSql = "select @name,@surname,@weight,@age,@height from dbo.myusers where @username like'" +s+"'";
            SqlCommand com = new SqlCommand(selectSql, con);
            //SqlCommand myCommand = new SqlCommand("select * from dbo.myusers where username='" + s + "'", con);

            textBoxName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxSurname.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxAge.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxWeight.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxHeight.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //myReader = myCommand.ExecuteReader();                    


        }


        public static int getId_Schedule
        {

            get { return Id_Schedule; }
            set { Id_Schedule = value; }
        }


    }
}
