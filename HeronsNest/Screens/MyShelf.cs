﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeronsNest.Screens
{
    public partial class MyShelf : UserControl
    {

        Landing mainForm;

        public MyShelf(Landing mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
        }

        private void MyShelf_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.SwitchView(new Home(mainForm));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }
    }
}
