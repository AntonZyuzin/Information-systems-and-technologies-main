using System;
using System.Drawing;
using System.Windows.Forms;
using Implementation8;

namespace Interface8
{
    public partial class Form1 : Form
    {
        private HouseConstruction _houseConstruction;
        private int i = 0;
        public Form1() {
            InitializeComponent();

            _houseConstruction = new HouseConstruction();
            _houseConstruction.MaterialsRanOut += _houseConstruction_MaterialsRanOut;
            _houseConstruction.Roof += _houseConstruction_Roof;
        }

        private void button1_Click(object sender, EventArgs e) {
            timer1_Tick(sender, e);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            string progress = _houseConstruction.DoWorkTick();
            richTextBox1.Text += $"{progress}{Environment.NewLine}";
            string[] pathToImage = new string[] { @"C:\Users\anton\Desktop\дом\2.jpg", @"C:\Users\anton\Desktop\дом\3.jpg",
                @"C:\Users\anton\Desktop\дом\4.jpg", @"C:\Users\anton\Desktop\дом\5.jpg", @"C:\Users\anton\Desktop\дом\6.jpg", @"C:\Users\anton\Desktop\дом\7.jpg", @"C:\Users\anton\Desktop\дом\8.jpg",
                @"C:\Users\anton\Desktop\дом\9.jpg", @"C:\Users\anton\Desktop\дом\10.jpg", @"C:\Users\anton\Desktop\дом\compl.jpg"};

            pictureBox1.Image = new Bitmap(pathToImage[i]);
            i += 1;
        }

        private void _houseConstruction_MaterialsRanOut(object sender, MaterialsRanOutArgs args) {
            richTextBox1.Text += $"Materials ran out, providing '2'...{Environment.NewLine}";
            _houseConstruction.StoneSupply += 2;
        }

        private void _houseConstruction_Roof(object sender, RoofArgs args) {
            richTextBox1.Text += $"Building the Roof.{Environment.NewLine}";
            richTextBox1.Text += $"House is complete!{Environment.NewLine}";
            timer1.Stop();
        }


    }
}
