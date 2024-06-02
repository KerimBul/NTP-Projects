using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string secilenYemek = textBox1.Text.ToLower(); // Girilen tüm harfleri küçük harfe çevirir.
            string yemekIcerik;
            double yemekUcret;

            switch (secilenYemek)
            {      //case: Seçilecek durumlardır.
                case "hamburger" :
                    yemekIcerik = "Patates, kola, ketçap ve mayonezle servis edilir.";
                    yemekUcret = 199.99;
                    break; // durumdan çıkmayı sağlar.
                case "pizza" :
                    yemekIcerik = "Patates, kola, ketçap ve mayonezle servis edilir.";
                    yemekUcret = 219.99;
                    break;
                default:
                    yemekIcerik = "Menümüzde böyle bir yemek bulunmamaktadır. ";
                    yemekUcret = 00.00;
                    break;
            }
            MessageBox.Show("Seçilen yemek: "+ secilenYemek.ToUpper() +"\nİçerik: "+yemekIcerik + "\nYemek Ücreti:" + yemekUcret.ToString("0.00"));
            // ToUpper() fonksiyonu tüm karakterleri büyük harfe çevirir.
        }
    }
}
