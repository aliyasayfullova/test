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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 d = new Form4();
            d.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 f = new Form6();
            f.Show();
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
    }
}
