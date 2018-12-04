namespace Main_Health_Partner
{
    partial class NutritionInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calories = new System.Windows.Forms.Label();
            this.fat = new System.Windows.Forms.Label();
            this.protein = new System.Windows.Forms.Label();
            this.carbs = new System.Windows.Forms.Label();
            this.caloriesInfo = new System.Windows.Forms.Label();
            this.fatInfo = new System.Windows.Forms.Label();
            this.proteinInfo = new System.Windows.Forms.Label();
            this.carbsInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calories
            // 
            this.Calories.AutoSize = true;
            this.Calories.Location = new System.Drawing.Point(30, 29);
            this.Calories.Name = "Calories";
            this.Calories.Size = new System.Drawing.Size(50, 13);
            this.Calories.TabIndex = 0;
            this.Calories.Text = "Calories :";
            // 
            // fat
            // 
            this.fat.AutoSize = true;
            this.fat.Location = new System.Drawing.Point(30, 64);
            this.fat.Name = "fat";
            this.fat.Size = new System.Drawing.Size(28, 13);
            this.fat.TabIndex = 1;
            this.fat.Text = "Fat :";
            // 
            // protein
            // 
            this.protein.AutoSize = true;
            this.protein.Location = new System.Drawing.Point(30, 97);
            this.protein.Name = "protein";
            this.protein.Size = new System.Drawing.Size(46, 13);
            this.protein.TabIndex = 2;
            this.protein.Text = "Protein :";
            // 
            // carbs
            // 
            this.carbs.AutoSize = true;
            this.carbs.Location = new System.Drawing.Point(30, 128);
            this.carbs.Name = "carbs";
            this.carbs.Size = new System.Drawing.Size(84, 13);
            this.carbs.TabIndex = 3;
            this.carbs.Text = "Carbohydrates : ";
            // 
            // caloriesInfo
            // 
            this.caloriesInfo.AutoSize = true;
            this.caloriesInfo.Location = new System.Drawing.Point(119, 29);
            this.caloriesInfo.Name = "caloriesInfo";
            this.caloriesInfo.Size = new System.Drawing.Size(21, 13);
            this.caloriesInfo.TabIndex = 4;
            this.caloriesInfo.Text = "cal";
            // 
            // fatInfo
            // 
            this.fatInfo.AutoSize = true;
            this.fatInfo.Location = new System.Drawing.Point(122, 64);
            this.fatInfo.Name = "fatInfo";
            this.fatInfo.Size = new System.Drawing.Size(19, 13);
            this.fatInfo.TabIndex = 5;
            this.fatInfo.Text = "fat";
            // 
            // proteinInfo
            // 
            this.proteinInfo.AutoSize = true;
            this.proteinInfo.Location = new System.Drawing.Point(122, 97);
            this.proteinInfo.Name = "proteinInfo";
            this.proteinInfo.Size = new System.Drawing.Size(39, 13);
            this.proteinInfo.TabIndex = 6;
            this.proteinInfo.Text = "protein";
            // 
            // carbsInfo
            // 
            this.carbsInfo.AutoSize = true;
            this.carbsInfo.Location = new System.Drawing.Point(122, 128);
            this.carbsInfo.Name = "carbsInfo";
            this.carbsInfo.Size = new System.Drawing.Size(33, 13);
            this.carbsInfo.TabIndex = 7;
            this.carbsInfo.Text = "carbs";
            // 
            // NutritionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(253, 190);
            this.Controls.Add(this.carbsInfo);
            this.Controls.Add(this.proteinInfo);
            this.Controls.Add(this.fatInfo);
            this.Controls.Add(this.caloriesInfo);
            this.Controls.Add(this.carbs);
            this.Controls.Add(this.protein);
            this.Controls.Add(this.fat);
            this.Controls.Add(this.Calories);
            this.Name = "NutritionInfo";
            this.Text = "Nutritional Information";
            this.Load += new System.EventHandler(this.NutritionInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Calories;
        private System.Windows.Forms.Label fat;
        private System.Windows.Forms.Label protein;
        private System.Windows.Forms.Label carbs;
        private System.Windows.Forms.Label caloriesInfo;
        private System.Windows.Forms.Label fatInfo;
        private System.Windows.Forms.Label proteinInfo;
        private System.Windows.Forms.Label carbsInfo;
    }
}