﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.ToLower() == "admin" && textBox2.Text == "admin")
            {
                // MessageBox.Show("Login Success");
                Home h = new Home();
                Hide();
                h.Show();
            }
            else
            {
                MessageBox.Show("Login Failed username or password invalid");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
