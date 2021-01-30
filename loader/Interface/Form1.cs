using System;
using System.Windows.Forms;

namespace Loader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface1.Form1 form = new Interface1.Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interface2.Form2 form = new Interface2.Form2();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Interface3.Form3 form = new Interface3.Form3();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Interface4.Form4 form = new Interface4.Form4();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Interface6.Form6 form = new Interface6.Form6();
            form.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/id160746710/");
        }

        private void button8_Click(object sender, EventArgs e) {
            var form = new Interface8.Form1();
            form.Show();
        }
    }
}
