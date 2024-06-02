using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizi_sesli_harf_sayisini_bulma
{
    public partial class Form1 : Form
    {
        char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            // Metin girişini al
            string metin = textBox1.Text.ToLower(); 
            // Harf büyüklüğünü dikkate almadan alınan metni küçük harflere dönüştür

            int sayac = 0;

    // Metindeki her bir harf için sesli harfleri kontrol et
    for (int i = 0; i < metin.Length; i++)
    {
        for (int j = 0; j < sesliHarfler.Length; j++)
        {
            if (metin[i] == sesliHarfler[j])
            {
                sayac++;
                break; // Sesli harf bulunduğunda iç döngüden çık
            }
        }
    }

    // Sonucu kullanıcıya göster
    label1.Text = "Metindeki sesli harf sayısı: " + sayac;
}


        }
    }

