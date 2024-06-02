using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tustakimi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "1";
            button1.BackColor = Color.Green;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "4";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "9";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Gold;
        }
       
    }
}
