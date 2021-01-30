using Implementation6;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interface6
{
    public partial class Form6 : Form
    {
        private readonly string[] Textures = {"Узор", "Рисунок", "Хлопок", "Лён"};

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            textBox2.Text = Textures[random.Next(0, 4)];
            numericUpDown1.Value = random.Next(900, 1100);
            numericUpDown2.Value = random.Next(80, 110);
            numericUpDown3.Value = random.Next(100, 150);
            ShowInformationBox("Случайные значения были успешно заданы!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var costume = new Costume((int)this.numericUpDown2.Value, (int)this.numericUpDown3.Value, (int)this.numericUpDown1.Value)
            {
                Texture = textBox2.Text
            };

            this.listBox1.Items.Add($"Costume #{this.listBox1.Items.Count}: {costume.Texture}:{costume.GetLength()}x{costume.GetHeight()}x{costume.GetWeight()}");
        }


        private void ShowInformationBox(string text)
        {
            MessageBox.Show(
                text,
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
