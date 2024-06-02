using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string[] isimler = { "Muhammed Ali Dursunoğlu", "Muhammet Taha Midi", "Deniz Arda Yigen", "Kerim Bülbül", "Nisanur Köprülü", "Ufuk Korkut", "Miray Topaç", "Emirhan Karaçavuş", "Alper Rıdvan Avbaz", "Berkay Süleymanoğlu", "Yusuf İslam Yılmaz", "Ömer Bulut", "Aziz Mete Bolat", "Arda Sever", "Hazal Doğan", "Kadir Çin", "Berat Antlı" };
        private bool spinning = false;

        private void button1_Click(object sender, EventArgs e)
        {

            /* int sayi;
             Random r = new Random();
             sayi = r.Next(0, 21);
             for (int i = 0; i <= 20; i++)
             {
                 textBox1.Text = listBox1.Items[i].ToString();
             }
             textBox1.Text = listBox1.Items[sayi].ToString();
             this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));*/

            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));

            if (!spinning)
            {
                // Çarkı döndürmek için yeni bir thread oluştur
                Thread spinThread = new Thread(new ThreadStart(SpinWheel));
                spinThread.Start();
            }
        }
        private void SpinWheel()
        {
            // Çarkın dönme efekti için 10 tur döndürüyoruz
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                int indeks = random.Next(isimler.Length);

                // Dönen ismi ekrana yazdır
                this.Invoke((MethodInvoker)delegate
                {
                    textBox1.Text = isimler[indeks];
                });

                // Küçük bir bekleme süresi ekleyerek dönme efektini simüle et
                Thread.Sleep(500);
            }

            // Dönme tamamlandığında çark durduğunu belirt
            spinning = false;
        }
    }
}
