using System;
using System.Windows.Forms;
using Implementation1;

namespace Interface1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown1.Value);
            Matrix.CustomizeTable(dataGridView1, n, n);
            Matrix.FillTable(
                ArrayUtils.GenerateRandomArray(n, n, Convert.ToInt32(numericUpDown3.Value),
                Convert.ToInt32(numericUpDown4.Value) + 1),
                dataGridView1);
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var scalar = Matrix.ScalarProduct(
                Matrix.GetFirstRowWithNegativeElement(dataGridView1),
                Matrix.GetLastRowWithZeroElement(dataGridView1)
            );


            MessageBox.Show(
                $"Cкалярное произведение строки и столбца, соответствующих строке с первым найденным отрицательным элементом и последним нулевым: '{scalar}'.",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }
    }
}
