using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Пр5
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
            dataGridView2.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown2.Value);
            dataGridView2.RowCount = Convert.ToInt32(numericUpDown2.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.Zapoln(dataGridView1, dataGridView2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1.Clear(dataGridView1, dataGridView2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.Result(dataGridView1, dataGridView2);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил Платов Андрей ИСП-41");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}