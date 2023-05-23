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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 d = new Form4();
            d.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 b = new Form1();
            b.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 g = new Form5();
            g.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
