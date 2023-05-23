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
    public partial class Form3 : Form
    {
        DataGridView dataGridView1 = new DataGridView();
        void Funtcion()
        {
            /*размер таблицы*/
            dataGridView1.Size = new Size(400, 200);

            /*создание столбцов*/
            //1 столбец, текстовый
            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.Name = "id";
            column0.HeaderText = "ID";
            //2 столбец, текстовый
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "brand";
            column1.HeaderText = "Brand";
         
            //добавляем столбцы
            dataGridView1.Columns.AddRange(column0, column1);

            /*создание ячеек*/
            //ячейки для 1 строки
            DataGridViewCell id0 = new DataGridViewTextBoxCell();
            DataGridViewCell brand0 = new DataGridViewTextBoxCell();
           
            id0.Value = "1";
            brand0.Value = "BMW";
           
            //создание строки
            DataGridViewRow row0 = new DataGridViewRow();
            //добавление ячеек в строку
            row0.Cells.AddRange(id0, brand0);
            //добавление строки в таблицу
            dataGridView1.Rows.Add(row0);

            //ячейки для 2 строки
            DataGridViewCell id1 = new DataGridViewTextBoxCell();
            DataGridViewCell brand1 = new DataGridViewTextBoxCell();
            id1.Value = "2";
            brand1.Value = "Bentley";
            //создание строки
            DataGridViewRow row1 = new DataGridViewRow();
            //добавление ячеек в строку
            row1.Cells.AddRange(id1, brand1);
            //добавление строки в таблицу
            dataGridView1.Rows.Add(row1);

            //ячейки для 3 строки
            DataGridViewCell id2 = new DataGridViewTextBoxCell();
            DataGridViewCell brand2 = new DataGridViewTextBoxCell();
            id2.Value = "3";
            brand2.Value = "Mercedes";
            //создание строки
            DataGridViewRow row2 = new DataGridViewRow();
            //добавление ячеек в строку
            row2.Cells.AddRange(id2, brand2);
            //добавление строки в таблицу
            dataGridView1.Rows.Add(row2);
        }
        public Form3()
        {
            InitializeComponent();
            //добавляем на форму таблицу
            this.Controls.Add(dataGridView1);
            Funtcion();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            c.Visible = false;
            Form1 b = new Form1();
            b.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            c.Visible = false; 
            Form4 d = new Form4();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            c.Visible = false;
            Form2 a = new Form2();
            a.Show();
        }
    }
}
