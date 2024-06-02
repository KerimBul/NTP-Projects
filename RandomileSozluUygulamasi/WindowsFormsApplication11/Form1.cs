using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            Random r = new Random();
            sayi = r.Next(0, 18);
            for (int i = 0; i <= 17; i++)
            {
                textBox1.Text = listBox1.Items[sayi].ToString();
            }
            textBox1.Text = listBox1.Items[sayi].ToString();
            this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }
    }
}
