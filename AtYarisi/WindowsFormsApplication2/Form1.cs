using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + 25;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Left = pictureBox2.Left + 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Left = pictureBox2.Left + 25;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 80; i++)
            {
                Random rnd = new Random();
                int sayi = rnd.Next(1,6);
                Random snd = new Random();
                int sayi2 = snd.Next(1,6);
                pictureBox1.Left = pictureBox1.Left + sayi;
                pictureBox2.Left = pictureBox2.Left + sayi2;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
