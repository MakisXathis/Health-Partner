﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            Login login = new Login();
            login.ShowDialog();

        }
    }
}