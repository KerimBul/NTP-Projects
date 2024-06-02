using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, string> ogrenciler = new Dictionary<int, string>();
        int anahtar;
        string deger;

        private void Listele()
        {
            listBox1.Items.Clear();
            foreach (var ogrenci in ogrenciler)
            {
                listBox1.Items.Add(ogrenci.Key + " - " + ogrenci.Value);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool durum = false;
            // okul no veya ad soyad olup olmadığı kontrol edilir.
            if (textBox1.Text!="") //textBox1 boş değilse
            {
                anahtar = Convert.ToInt32(textBox1.Text); //Okul No
                durum = ogrenciler.ContainsKey(anahtar);
            }
            else
            {
                anahtar = Convert.ToInt32(textBox1.Text); //Okul No
                durum = ogrenciler.ContainsValue(deger);
            }

            if (durum==true)
            {
                MessageBox.Show("Öğrenci Kayıtlıdır");
            }
            else
            {
                MessageBox.Show("Oğrenci kayıtlı değil !");    
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anahtar = Convert.ToInt32(textBox1.Text); //Okul No
            deger = textBox2.Text; // Ad Soyad
            ogrenciler.Add(anahtar, deger); // Okul No - Ad Soyad
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anahtar = Convert.ToInt32(textBox1.Text); //Okul No
            deger = textBox2.Text; // Ad Soyad
            ogrenciler[anahtar] = deger;
            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            anahtar = Convert.ToInt32(textBox1.Text);
            ogrenciler.Remove(anahtar); 
            //anahtar silinirse tuttuğu değer de silinir
            Listele();
        }
    }
}
