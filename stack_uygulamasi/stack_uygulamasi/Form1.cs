using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stack_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack yigin = new Stack();
        private void Listele()
        {
            listBox1.Items.Clear();
            foreach (string eleman in yigin)
            {
                listBox1.Items.Add(eleman);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            yigin.Push(textBox1.Text);
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yigin.Pop();
            Listele();
        }

    }
}
