﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayf
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 b = new Form1();
            b.Visible = false;
            Form2 a = new Form2();
            a.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
