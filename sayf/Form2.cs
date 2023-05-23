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
    public partial class Form2 : Form
    {
        public Form2() => InitializeComponent();

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 d = new Form4();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 с = new Form3();
            с.Show();
        }
    }
}
