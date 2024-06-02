using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizi_ozellikleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dizi tanımlaması
            int[] sayilar = { 5, 8, 16, 18, 6 };

            //Length: Dizi uzunluğu
            int length = sayilar.Length;
            label1.Text = "Dizi uzunluğu: " + length;

            //Rank: Dizi boyutu
            int rank = sayilar.Rank;
            label2.Text = "Dizi boyutu: " + rank;


            //Max: Dizideki en büyük değer
            int max = sayilar.Max();
            label3.Text = "Dizideki en büyük değer: " + max;

            //Min: Dizideki en küçük değer
            int min = sayilar.Min();
            label4.Text = "Dizideki en küçük değer: " + min;

            //Sum: Dizideki elemanların toplaması
            int sum = sayilar.Sum();
            label5.Text = "Dizideki toplam: " + sum;

            //Average: Dizideki elemanların ortalaması
            double average = sayilar.Average();
            label6.Text = "Dizideki sayıların ortalaması: " + average;

            //Firs: Dizinin ilk elemanı
            int first = sayilar.First();
            label7.Text = "Dizinin ilk elemanı: " + first;

            //Last: Dizinin son elemanı
            int last = sayilar.Last();
            label8.Text = "Dizinin son elemanı: " + last;


        }
    }
}
