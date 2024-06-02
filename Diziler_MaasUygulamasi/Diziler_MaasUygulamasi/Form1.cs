using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_MaasUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //int index = 0;
        string[] personeller;
        int[] maaslar;

        private void button1_Click(object sender, EventArgs e)
        {
            // OLUŞTUR VE LİSTELE
            listBox1.Items.Clear();
            personeller = new string[] { "Nisa", "Kerim", "Taha", "Deniz", "Miray", "Hazal", "Arda" };
            maaslar = new int[] { 20000, 25000, 19000, 52000, 65000, 18000, 51000 };
            for (int i = 0; i < personeller.Length; i++)
            {
                listBox1.Items.Add(personeller[i] + "\t" + maaslar[i]);
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            // PERSONEL ARAMA
            string aranan = textBox1.Text;
            bool bulundu = false;
            for (int i = 0; i < personeller.Length; i++)
            {
                if (aranan==personeller[i])
                {
                    bulundu = true;
                    listBox1.SelectedIndex = i;
                    break;
                }   
            }
            if (bulundu)
            {
                MessageBox.Show("Personel Bulundu");
            }
            else 
            {
                MessageBox.Show("Personel Bulunamadı");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // LİSTEYİ TEMİZLE
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TOPLAM PERSONEL SAYISI
            label2.Text = "TOPLAM PERSONEL SAYISI : " + personeller.Length;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // EN DÜŞÜK MAAŞ
            int dusuk = maaslar[0];
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (dusuk>maaslar[i])
                {
                    dusuk = maaslar[i];
                }
            }
            label2.Text = "En Düşük Maaş  : " + dusuk;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // EN YÜKSEK MAAŞ ALAN PERSONEL
            int yuksek = maaslar[0];
            int yuksekIndex = 0;
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (yuksek < maaslar[i])
                {
                    yuksek = maaslar[i];
                    yuksekIndex = i;
                }
            }
            label2.Text = "En Yuksek Maas Alan: " + personeller[yuksekIndex];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //MAAŞI 20.000 DEN AZ OLANLAR
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (maaslar[i]<20000)
                {
                    listBox1.Items.Add(personeller[i] + ">>" + maaslar[i]);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //MAAŞ 50.000-70.000 ARASI OLANLAR
            int sayac = 0;
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (maaslar[i]>=50000 && maaslar[i] <=70000)
                {
                    sayac++;
                }
            }
            label2.Text = "50000-70000 arasında olanların sayısı : " + sayac;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // TOPLAM ÖDENEN MAAŞ TUTARI
            int toplam =0;
            for (int i = 0; i < maaslar.Length; i++)
            {
                toplam += maaslar[i];
            }
            label2.Text = "Toplam Ödenen Maaş Tutarı : " + toplam;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // 3 NOLU PERSONELİ 500₺ ARTTIRMA
            listBox1.Items.Clear();
            maaslar[2] += 500;
            for (int i = 0; i < personeller.Length; i++)
            {
                listBox1.Items.Add(personeller[i] + "\t" + maaslar[i]);
            }
        }
        private void button10_Click(object sender, EventArgs e)
        // SON PERSONELİ GÖSTERME
        {
            MessageBox.Show(personeller[6]);
        }
    }
}
