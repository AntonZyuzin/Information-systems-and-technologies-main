using System;
using System.IO;
using System.Windows.Forms;
using Implementation2;

namespace Interface2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox4.Text = new FileInfo(Directory.GetCurrentDirectory()).Directory.Parent.Parent.Parent.FullName + "\\task2\\Temp";
            openFileDialog1.InitialDirectory = textBox4.Text;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Текстовый файл|*.txt";
            openFileDialog1.RestoreDirectory = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = new FileInfo(openFileDialog1.FileName).Directory.FullName;
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    textBox1.Text = reader.ReadToEnd().Replace("\n", Environment.NewLine);
                }
            }
            else
            {
                MessageBox.Show(
                "Файл не был выбран!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void button7_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                textBox4.Text = new FileInfo(openFileDialog1.FileName).Directory.FullName;
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName)) {
                    textBox2.Text = reader.ReadToEnd().Replace("\n", Environment.NewLine);
                }
            } else {
                MessageBox.Show(
                "Файл не был выбран!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void button2_Click_1(object sender, EventArgs e) {
            textBox3.Text = StringUtils.Merge(textBox1.Text, textBox2.Text);
        }
    }
}
