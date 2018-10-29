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
    public partial class Info_Recipe : Form
    {
        public Info_Recipe()
        {
            InitializeComponent();
        }

        private void Info_Recipe_Load(object sender, EventArgs e)
        {

            textBoxIngredients.Text = Form_Main.getRecipeInfo;
            textBoxSteps.Text = Form_Main.getRecipesteps;
        }
    }
}
