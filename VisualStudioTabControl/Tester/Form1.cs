﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Dark();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Blue();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new Light();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new msg();
            f.Show();
        }
    }
}
