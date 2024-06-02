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
            // dizideki �ift sayilari ekrana yazd�rma
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
            // dizideki elemanlar�n toplam de�erini ekrana yazd�rma
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            MessageBox.Show("Toplam De�eri: " + toplam.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // dizinin eleman say�s�n� yazd�rma
            int[] sayilar = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                MessageBox.Show(sayilar[i].ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 3'e ve 5'e tam b�l�nenleri listboxa yazd�rma
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
            // String dizisi olu�turup elemanlar� lisboxa ekle
            string[] dizi = new string[5];
            dizi[0] = "Buse";
            dizi[1] = "Evin";
            dizi[2] = "Gamze";
            dizi[3] = "Doni";
            dizi[4] = "Badi";

            // Her bir eleman� ekranda g�stermek i�in foreach d�ng�s� kullanal�m
            foreach (string eleman in dizi)
            {
                // TextBox kontrol�nde her bir eleman� yeni sat�ra yazd�r�n
                textBox1.Text += eleman + Environment.NewLine;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //kullan�c�n�n girdi�i metindeki sesli harf say�s�n� bulma
            char[] harfler = { 'a', 'e', '�', 'i', 'o', '�', 'u', '�' };
            string metin = textBox1.Text.ToLower();
            // Harf b�y�kl���n� dikkate almadan al�nan metni k���k harflere d�n��t�r

            int sayac = 0;

            // Metindeki her bir harf i�in sesli harfleri kontrol et
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
            label1.Text = "Metindeki sesli harf say�s�: " + sayac;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // elemanlar�n ortalamas�n� bulun
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
            // 5 sat�r ve 2 s�tundan olu�an bir string dizi olu�turuldu
            string[,] b�lgeler = new string[5, 2]
            {
                { "�stanbul","�zmit" },
                { "Ankara","Konya" },
                { "Antalya","Adana" },
                { "Rize","Trabzon" },
                { "�zmir","Mu�la" }
            };

            // Dizi i�indeki her bir eleman� ekrana yazd�rmak i�in iki d�ng� kullan�l�r
            for (int i = 0; i <= b�lgeler.GetUpperBound(0); i++) // Sat�rlar boyunca d�ng�
            {
                for (int j = 0; j <= b�lgeler.GetUpperBound(1); j++) // S�tunlar boyunca d�ng�
                {
                    // �lgili sat�r ve s�tundaki de�eri ekrana yazd�r
                    listBox1.Items.Add(b�lgeler[i, j]);  // De�erler aras�na bir tab karakteri ekleyerek yazd�rma
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // en b�y�k say�y� bulma
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int yuksek = sayilar[0];
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (yuksek < sayilar[i])
                {
                    yuksek = sayilar[i];
                }
            }
            label1.Text = "En Y�ksek Not : " + yuksek.ToString();
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
                MessageBox.Show("HATA OLU�TU! ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0); // PROGRAM SONLANDIRILIR 
                // SIFIR PROGRAMIN NORMAL B�R �EK�LDE SONLANDI�INI �FADE EDER
            }
        }
    }

}
