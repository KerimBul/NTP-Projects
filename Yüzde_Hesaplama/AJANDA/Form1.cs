using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJANDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Text = "%10";
            radioButton2.Text = "%20";
            radioButton3.Text = "%30";
            radioButton4.Text = "%40";
            radioButton5.Text = "%50";
            radioButton6.Text = "%60";
            radioButton7.Text = "%70";
            radioButton8.Text = "%80";
            radioButton9.Text = "%90";
            radioButton10.Text = "%100";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kar = Convert.ToInt32(textBox1.Text);

            if (radioButton1.Checked==true)
            {
                label1.Text = Convert.ToString(kar + (kar * 0.10));
            }
            else if (radioButton2.Checked == true)
            {
                label1.Text = Convert.ToString(kar + (kar * 0.20));
            }
            else if (radioButton3.Checked == true)
            {
                label1.Text = Convert.ToString(kar + (kar * 0.30));
            }
            else if (radioButton4.Checked == true)
            {
                label1.Text = Convert.ToString(kar + (kar * 0.40));
            }
            else if (radioButton5.Checked == true)
            {
                label1.Text = Convert.ToString(kar + (kar * 0.50));
            }
            else if (radioButton6.Checked == true)
            {
                label1.Text = Convert.ToString(kar + (kar * 0.60));
            }
            else if (radioButton7.Checked == true)
            {
                label1.Text = Convert.ToString(kar + (kar * 0.70));
            }
            else if (radioButton8.Checked == true)
            {
                label1.Text = Convert.ToString(kar + (kar * 0.80));
            }
            else if (radioButton9.Checked == true)
            {
                label1.Text = Convert.ToString(kar + (kar * 0.90));
            }
            else if (radioButton10.Checked == true)
            {
                label1.Text = Convert.ToString(kar + (kar * 1.00));
            }
        }

        
    }
}
