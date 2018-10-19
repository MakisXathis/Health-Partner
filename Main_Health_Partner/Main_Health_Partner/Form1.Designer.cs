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
            this.tabPageSessure = new System.Windows.Forms.TabPage();
            this.tabPageProgress = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonAbout = new System.Windows.Forms.Button();
            this.Profile.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // Profile
            // 
            this.Profile.Controls.Add(this.tabPageProfile);
            this.Profile.Controls.Add(this.tabPageSessure);
            this.Profile.Controls.Add(this.tabPageProgress);
            this.Profile.Location = new System.Drawing.Point(0, 2);
            this.Profile.Name = "Profile";
            this.Profile.SelectedIndex = 0;
            this.Profile.Size = new System.Drawing.Size(801, 451);
            this.Profile.TabIndex = 0;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPageProfile.Controls.Add(this.buttonAbout);
            this.tabPageProfile.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(793, 425);
            this.tabPageProfile.TabIndex = 0;
            this.tabPageProfile.Text = "Profile";
            // 
            // tabPageSessure
            // 
            this.tabPageSessure.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPageSessure.Location = new System.Drawing.Point(4, 22);
            this.tabPageSessure.Name = "tabPageSessure";
            this.tabPageSessure.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSessure.Size = new System.Drawing.Size(793, 425);
            this.tabPageSessure.TabIndex = 1;
            this.tabPageSessure.Text = "Sessure";
            // 
            // tabPageProgress
            // 
            this.tabPageProgress.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPageProgress.Location = new System.Drawing.Point(4, 22);
            this.tabPageProgress.Name = "tabPageProgress";
            this.tabPageProgress.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProgress.Size = new System.Drawing.Size(793, 425);
            this.tabPageProgress.TabIndex = 2;
            this.tabPageProgress.Text = "Progress";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Logo.png");
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(709, 6);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(84, 38);
            this.buttonAbout.TabIndex = 0;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Profile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Health Partner";
            this.Profile.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Profile;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabPageSessure;
        private System.Windows.Forms.TabPage tabPageProgress;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonAbout;
    }
}

