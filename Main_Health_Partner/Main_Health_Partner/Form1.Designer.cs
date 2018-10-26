namespace Main_Health_Partner
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.Profile = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDatabaseMyUsers = new Main_Health_Partner.MyDatabaseMyUsers();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.tabPageSessure = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.dataGridViewFood = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Food_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.myusersTableAdapter = new Main_Health_Partner.MyDatabaseMyUsersTableAdapters.myusersTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMaxCalories = new System.Windows.Forms.TextBox();
            this.textBoxMinCalories = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMinProtein = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMaxProtein = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxMinFat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxMaxFat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxMinCarbs = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxMaxCarbs = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Profile.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myusersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseMyUsers)).BeginInit();
            this.tabPageSessure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Profile
            // 
            this.Profile.Controls.Add(this.tabPageProfile);
            this.Profile.Controls.Add(this.tabPageSessure);
            this.Profile.Controls.Add(this.tabPageSearch);
            this.Profile.Location = new System.Drawing.Point(0, 2);
            this.Profile.Name = "Profile";
            this.Profile.SelectedIndex = 0;
            this.Profile.Size = new System.Drawing.Size(801, 451);
            this.Profile.TabIndex = 0;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPageProfile.Controls.Add(this.pictureBox1);
            this.tabPageProfile.Controls.Add(this.dataGridView1);
            this.tabPageProfile.Controls.Add(this.textBoxHeight);
            this.tabPageProfile.Controls.Add(this.textBoxWeight);
            this.tabPageProfile.Controls.Add(this.textBoxAge);
            this.tabPageProfile.Controls.Add(this.textBoxSurname);
            this.tabPageProfile.Controls.Add(this.textBoxName);
            this.tabPageProfile.Controls.Add(this.buttonSave);
            this.tabPageProfile.Controls.Add(this.buttonEdit);
            this.tabPageProfile.Controls.Add(this.label5);
            this.tabPageProfile.Controls.Add(this.label4);
            this.tabPageProfile.Controls.Add(this.label3);
            this.tabPageProfile.Controls.Add(this.label2);
            this.tabPageProfile.Controls.Add(this.label1);
            this.tabPageProfile.Controls.Add(this.buttonAbout);
            this.tabPageProfile.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(793, 425);
            this.tabPageProfile.TabIndex = 0;
            this.tabPageProfile.Text = "Profile";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.myusersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(502, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(139, 106);
            this.dataGridView1.TabIndex = 14;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // myusersBindingSource
            // 
            this.myusersBindingSource.DataMember = "myusers";
            this.myusersBindingSource.DataSource = this.myDatabaseMyUsers;
            // 
            // myDatabaseMyUsers
            // 
            this.myDatabaseMyUsers.DataSetName = "MyDatabaseMyUsers";
            this.myDatabaseMyUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Enabled = false;
            this.textBoxHeight.Location = new System.Drawing.Point(133, 217);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 13;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Enabled = false;
            this.textBoxWeight.Location = new System.Drawing.Point(133, 171);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 12;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Enabled = false;
            this.textBoxAge.Location = new System.Drawing.Point(133, 132);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 11;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Enabled = false;
            this.textBoxSurname.Location = new System.Drawing.Point(133, 91);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 10;
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(133, 49);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(237, 315);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(98, 315);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Height :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Weight :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Age :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(706, 3);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(84, 38);
            this.buttonAbout.TabIndex = 0;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // tabPageSessure
            // 
            this.tabPageSessure.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPageSessure.Controls.Add(this.dataGridView2);
            this.tabPageSessure.Controls.Add(this.label6);
            this.tabPageSessure.Controls.Add(this.textBox1);
            this.tabPageSessure.Controls.Add(this.buttonSearch);
            this.tabPageSessure.Location = new System.Drawing.Point(4, 22);
            this.tabPageSessure.Name = "tabPageSessure";
            this.tabPageSessure.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSessure.Size = new System.Drawing.Size(793, 425);
            this.tabPageSessure.TabIndex = 1;
            this.tabPageSessure.Text = "Sessure";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(36, 85);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(734, 312);
            this.dataGridView2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "How many calories to eat every day?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(496, 33);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPageSearch.Controls.Add(this.textBoxMaxCarbs);
            this.tabPageSearch.Controls.Add(this.label15);
            this.tabPageSearch.Controls.Add(this.textBoxMinCarbs);
            this.tabPageSearch.Controls.Add(this.label14);
            this.tabPageSearch.Controls.Add(this.textBoxMaxFat);
            this.tabPageSearch.Controls.Add(this.label13);
            this.tabPageSearch.Controls.Add(this.textBoxMinFat);
            this.tabPageSearch.Controls.Add(this.label12);
            this.tabPageSearch.Controls.Add(this.textBoxMaxProtein);
            this.tabPageSearch.Controls.Add(this.label11);
            this.tabPageSearch.Controls.Add(this.textBoxMinProtein);
            this.tabPageSearch.Controls.Add(this.label10);
            this.tabPageSearch.Controls.Add(this.textBoxMinCalories);
            this.tabPageSearch.Controls.Add(this.label9);
            this.tabPageSearch.Controls.Add(this.textBoxMaxCalories);
            this.tabPageSearch.Controls.Add(this.label8);
            this.tabPageSearch.Controls.Add(this.dataGridViewFood);
            this.tabPageSearch.Controls.Add(this.button1);
            this.tabPageSearch.Controls.Add(this.textBoxSearch);
            this.tabPageSearch.Controls.Add(this.label7);
            this.tabPageSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Size = new System.Drawing.Size(793, 425);
            this.tabPageSearch.TabIndex = 2;
            this.tabPageSearch.Text = "Search";
            // 
            // dataGridViewFood
            // 
            this.dataGridViewFood.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Food_Name,
            this.Image});
            this.dataGridViewFood.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewFood.Location = new System.Drawing.Point(0, 107);
            this.dataGridViewFood.Name = "dataGridViewFood";
            this.dataGridViewFood.RowTemplate.Height = 50;
            this.dataGridViewFood.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFood.Size = new System.Drawing.Size(793, 315);
            this.dataGridViewFood.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DividerWidth = 5;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 40;
            this.Id.Name = "Id";
            // 
            // Food_Name
            // 
            this.Food_Name.DividerWidth = 5;
            this.Food_Name.HeaderText = "Name";
            this.Food_Name.MinimumWidth = 45;
            this.Food_Name.Name = "Food_Name";
            // 
            // Image
            // 
            this.Image.DividerWidth = 5;
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 55;
            this.Image.Name = "Image";
            this.Image.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Press";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(86, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(260, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Food search :";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Logo.png");
            // 
            // myusersTableAdapter
            // 
            this.myusersTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Max Calories :";
            // 
            // textBoxMaxCalories
            // 
            this.textBoxMaxCalories.Location = new System.Drawing.Point(84, 63);
            this.textBoxMaxCalories.Name = "textBoxMaxCalories";
            this.textBoxMaxCalories.Size = new System.Drawing.Size(85, 20);
            this.textBoxMaxCalories.TabIndex = 5;
            this.textBoxMaxCalories.Text = "100";
            // 
            // textBoxMinCalories
            // 
            this.textBoxMinCalories.Location = new System.Drawing.Point(84, 36);
            this.textBoxMinCalories.Name = "textBoxMinCalories";
            this.textBoxMinCalories.Size = new System.Drawing.Size(85, 20);
            this.textBoxMinCalories.TabIndex = 7;
            this.textBoxMinCalories.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Min Calories :";
            // 
            // textBoxMinProtein
            // 
            this.textBoxMinProtein.Location = new System.Drawing.Point(261, 37);
            this.textBoxMinProtein.Name = "textBoxMinProtein";
            this.textBoxMinProtein.Size = new System.Drawing.Size(85, 20);
            this.textBoxMinProtein.TabIndex = 9;
            this.textBoxMinProtein.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Min Protein :";
            // 
            // textBoxMaxProtein
            // 
            this.textBoxMaxProtein.Location = new System.Drawing.Point(261, 63);
            this.textBoxMaxProtein.Name = "textBoxMaxProtein";
            this.textBoxMaxProtein.Size = new System.Drawing.Size(85, 20);
            this.textBoxMaxProtein.TabIndex = 11;
            this.textBoxMaxProtein.Text = "100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Max Protein :";
            // 
            // textBoxMinFat
            // 
            this.textBoxMinFat.Location = new System.Drawing.Point(417, 37);
            this.textBoxMinFat.Name = "textBoxMinFat";
            this.textBoxMinFat.Size = new System.Drawing.Size(85, 20);
            this.textBoxMinFat.TabIndex = 13;
            this.textBoxMinFat.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Min Fat :";
            // 
            // textBoxMaxFat
            // 
            this.textBoxMaxFat.Location = new System.Drawing.Point(417, 63);
            this.textBoxMaxFat.Name = "textBoxMaxFat";
            this.textBoxMaxFat.Size = new System.Drawing.Size(85, 20);
            this.textBoxMaxFat.TabIndex = 15;
            this.textBoxMaxFat.Text = "100";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(363, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Max Fat :";
            // 
            // textBoxMinCarbs
            // 
            this.textBoxMinCarbs.Location = new System.Drawing.Point(572, 37);
            this.textBoxMinCarbs.Name = "textBoxMinCarbs";
            this.textBoxMinCarbs.Size = new System.Drawing.Size(85, 20);
            this.textBoxMinCarbs.TabIndex = 17;
            this.textBoxMinCarbs.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(506, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Min Carbs :";
            // 
            // textBoxMaxCarbs
            // 
            this.textBoxMaxCarbs.Location = new System.Drawing.Point(572, 63);
            this.textBoxMaxCarbs.Name = "textBoxMaxCarbs";
            this.textBoxMaxCarbs.Size = new System.Drawing.Size(85, 20);
            this.textBoxMaxCarbs.TabIndex = 19;
            this.textBoxMaxCarbs.Text = "500";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(506, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Max Carbs :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Main_Health_Partner.Properties.Resources.businessman_xxl1;
            this.pictureBox1.Location = new System.Drawing.Point(429, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // foodBindingSource
            // 
            this.foodBindingSource.DataSource = typeof(Main_Health_Partner.Food);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Profile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Health Partner";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Profile.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myusersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseMyUsers)).EndInit();
            this.tabPageSessure.ResumeLayout(false);
            this.tabPageSessure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Profile;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabPageSessure;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MyDatabaseMyUsers myDatabaseMyUsers;
        private System.Windows.Forms.BindingSource myusersBindingSource;
        private MyDatabaseMyUsersTableAdapters.myusersTableAdapter myusersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewFood;
        private System.Windows.Forms.BindingSource foodBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Food_Name;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.TextBox textBoxMaxCalories;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMinCalories;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMinProtein;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxMaxProtein;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxMinFat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxMaxFat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxMaxCarbs;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxMinCarbs;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

