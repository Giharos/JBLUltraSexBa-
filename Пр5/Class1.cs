using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр5
{
    class Class1
    {
        public static void Zapoln(DataGridView dataGridView1, DataGridView dataGridView2)
        {
            Random Rand = new Random();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                for (int j = 0; j < dataGridView1.RowCount; j++)
                    dataGridView1[i, j].Value = Rand.Next(100);
            for (int i = 0; i < dataGridView2.ColumnCount; i++)
                for (int j = 0; j < dataGridView2.RowCount; j++)
                    dataGridView2[i, j].Value = Rand.Next(100);
        }
        public static void Clear(DataGridView dataGridView1, DataGridView dataGridView2)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                for (int j = 0; j < dataGridView1.RowCount; j++)
                    dataGridView1[i, j].Value = " ";
            for (int i = 0; i < dataGridView2.ColumnCount; i++)
                for (int j = 0; j < dataGridView2.RowCount; j++)
                    dataGridView2[i, j].Value = " ";
        }
        public static void Result(DataGridView dataGridView1, DataGridView dataGridView2)
        {
            int min;
            int nMin;
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                min = Convert.ToInt32(dataGridView1[0, j].Value);
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                   

                }
            }
        }
    }
}
