using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Rakam_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void button3_Rakam_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void button4_Rakam_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button5_Rakam_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void button6_Rakam_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button9_Rakam_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void button8_Rakam_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void button7_Rakam_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void button0_Rakam_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }
    }
}
