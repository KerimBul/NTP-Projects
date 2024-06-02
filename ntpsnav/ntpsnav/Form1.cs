using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ntpsnav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // dizideki çift sayilari ekrana yazdýrma
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    //MessageBox.Show(sayilar[i].ToString());
                    listBox1.Items.Add(sayilar[i].ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // dizideki elemanlarýn toplam deðerini ekrana yazdýrma
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            MessageBox.Show("Toplam Deðeri: " + toplam.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // dizinin eleman sayýsýný yazdýrma
            int[] sayilar = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                MessageBox.Show(sayilar[i].ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 3'e ve 5'e tam bölünenleri listboxa yazdýrma
            int[] diziler = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int i = 0; i < diziler.Length; i++)
            {
                if (diziler[i] % 5 == 0 && diziler[i] % 3 == 0)
                {
                    listBox1.Items.Add(diziler[i].ToString());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // String dizisi oluþturup elemanlarý lisboxa ekle
            string[] dizi = new string[5];
            dizi[0] = "Buse";
            dizi[1] = "Evin";
            dizi[2] = "Gamze";
            dizi[3] = "Doni";
            dizi[4] = "Badi";

            // Her bir elemaný ekranda göstermek için foreach döngüsü kullanalým
            foreach (string eleman in dizi)
            {
                // TextBox kontrolünde her bir elemaný yeni satýra yazdýrýn
                textBox1.Text += eleman + Environment.NewLine;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //kullanýcýnýn girdiði metindeki sesli harf sayýsýný bulma
            char[] harfler = { 'a', 'e', 'ý', 'i', 'o', 'ö', 'u', 'ü' };
            string metin = textBox1.Text.ToLower();
            // Harf büyüklüðünü dikkate almadan alýnan metni küçük harflere dönüþtür

            int sayac = 0;

            // Metindeki her bir harf için sesli harfleri kontrol et
            for (int i = 0; i < metin.Length; i++)
            {
                for (int j = 0; j < harfler.Length; j++)
                {
                    if (metin[i] == harfler[j])
                    {
                        sayac++;
                        break;
                    }
                }
            }
            label1.Text = "Metindeki sesli harf sayýsý: " + sayac;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // elemanlarýn ortalamasýný bulun
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }

            int ortalama = toplam / sayilar.Length;
            label1.Text = "Ortalama : " + ortalama.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // 5 satýr ve 2 sütundan oluþan bir string dizi oluþturuldu
            string[,] bölgeler = new string[5, 2]
            {
                { "Ýstanbul","Ýzmit" },
                { "Ankara","Konya" },
                { "Antalya","Adana" },
                { "Rize","Trabzon" },
                { "Ýzmir","Muðla" }
            };

            // Dizi içindeki her bir elemaný ekrana yazdýrmak için iki döngü kullanýlýr
            for (int i = 0; i <= bölgeler.GetUpperBound(0); i++) // Satýrlar boyunca döngü
            {
                for (int j = 0; j <= bölgeler.GetUpperBound(1); j++) // Sütunlar boyunca döngü
                {
                    // Ýlgili satýr ve sütundaki deðeri ekrana yazdýr
                    listBox1.Items.Add(bölgeler[i, j]);  // Deðerler arasýna bir tab karakteri ekleyerek yazdýrma
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // en büyük sayýyý bulma
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int yuksek = sayilar[0];
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (yuksek < sayilar[i])
                {
                    yuksek = sayilar[i];
                }
            }
            label1.Text = "En Yüksek Not : " + yuksek.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // IndexOutOfRangeException
            try
            {
                int[] dizi = { 1, 2, 3 };
                int eleman = dizi[5];
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("HATA OLUÞTU! ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0); // PROGRAM SONLANDIRILIR 
                // SIFIR PROGRAMIN NORMAL BÝR ÞEKÝLDE SONLANDIÐINI ÝFADE EDER
            }
        }
    }

}
