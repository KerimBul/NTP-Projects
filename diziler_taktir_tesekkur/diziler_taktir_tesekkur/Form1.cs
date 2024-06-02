using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler_taktir_tesekkur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        string[] ogrenciler = new string[10];
        int[] ortalamalar = new int[10];
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciler[i] = textBox1.Text;
            ortalamalar[i] = Convert.ToInt32(textBox2.Text);
            i++;
            if (i==10)
            {
                button1.Enabled=false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for ( i = 0; i < ogrenciler.Length; i++)
            {
                listBox1.Items.Add(ogrenciler[i]+ "\t" + ortalamalar[i]);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (i = 0; i < ogrenciler.Length; i++)
            {
                if (ortalamalar[i]<50)
                {
                    listBox1.Items.Add(ogrenciler[i]+ "\t" + ortalamalar[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (i = 0; i < ogrenciler.Length; i++)
            {
                if (ortalamalar[i] >= 50)
                {
                    listBox1.Items.Add(ogrenciler[i] + "\t" + ortalamalar[i]);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            for (i = 0; i < ogrenciler.Length; i++)
            {
                if (ortalamalar[i] >= 70 && ortalamalar[i]<85)
                {
                    listBox1.Items.Add(ogrenciler[i] + "\t" + ortalamalar[i]);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (i = 0; i < ogrenciler.Length; i++)
            {
                if (ortalamalar[i] >= 85 && ortalamalar[i] < 100)
                {
                    listBox1.Items.Add(ogrenciler[i] + "\t" + ortalamalar[i]);
                }
            }
        }
    }
}
