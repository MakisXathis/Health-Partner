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
    public partial class NutritionInfo : Form
    {
        public NutritionInfo()
        {
            InitializeComponent();
        }

        private void NutritionInfo_Load(object sender, EventArgs e)
        {

        }

        public void setCalories(String cal)
        {
            caloriesInfo.Text = cal;
        }

        public void setFat(String fat)
        {
            fatInfo.Text = fat;
        }

        public void setProtein(String protein)
        {
            proteinInfo.Text = protein;
        }

        public void setCarbs(String carbs)
        {
            carbsInfo.Text = carbs;
        }

    }
}
