using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 b = new Form1();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 a = new Form2();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 c = new Form3();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 g = new Form5();
            g.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 f = new Form6();
            f.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
