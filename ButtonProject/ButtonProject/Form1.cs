﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ACTION_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello party people");
            string words = textBox1.Text;
            label1.Text = words;
            label2.Text = "coded";
            label3.Text = "Dat";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           



        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
