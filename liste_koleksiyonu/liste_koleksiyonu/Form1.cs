using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liste_koleksiyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> sehirler = new List<string>();
        private void Listele()
        {
            listBox1.Items.Clear();
            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {   
            sehirler.Add("İstanbul");
            sehirler.Add("Mardin");
            sehirler.Add("Kastamonu");
            sehirler.Add("Edirne");
            sehirler.Add("Artvin");
            sehirler.Add("Siirt");
            sehirler.Add("Elazığ");
            sehirler.Add("AFYONKARAHİSAR");
            Listele();
            int sayi = sehirler.Count;
            label1.Text = "Toplam Sayı : " + sayi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(17);
            int toplam = 0;
            for (int i = 0; i < sayilar.Count; i++)
            {
                toplam += sayilar[i];
            }
            label1.Text = "Toplam : " + toplam;
        }
        private void sayilarListele()
        {
            listBox1.Items.Clear();
            foreach (string sayi in sayilar)
            {
                listBox1.Items.Add(sayi.ToString);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(17);
            int secili = listBox1.SelectedIndex;
            sayilar.Remove(secili);
        }
        }

    }

