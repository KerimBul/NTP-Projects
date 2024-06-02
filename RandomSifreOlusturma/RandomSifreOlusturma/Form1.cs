using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSifreOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string KucukHarfHavuzu = "abcdefghijklmnopqrstuvwxyz";
        private string BuyukHarfHavuzu = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string SayiHavuzu = "0123456789";
        private string SembolHavuzu = "!@#$%^&*()-_=+[]{};:,<.>?";
        
        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Maximum = 20;
            int sifreUzunlugu = trackBar1.Value; // Kaydırıcıdan şifre uzunluğunu al
            label1.Text = trackBar1.Value.ToString();

            string karakterler = "";

            if (checkBox1.Checked)
                karakterler += KucukHarfHavuzu;

            if (checkBox2.Checked)
                karakterler += BuyukHarfHavuzu;

            if (checkBox3.Checked)
                karakterler += SayiHavuzu;

            if (checkBox4.Checked)
                karakterler += SembolHavuzu;

            Random random = new Random();
            string sifre = "";

            for (int i = 0; i < sifreUzunlugu; i++)
            {
                sifre += karakterler[random.Next(0, karakterler.Length)];
            }

            textBox1.Text = sifre;
        }
        

       

       
    }

    }

