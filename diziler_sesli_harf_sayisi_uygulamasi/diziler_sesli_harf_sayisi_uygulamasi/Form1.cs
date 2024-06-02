using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace diziler_sesli_harf_sayisi_uygulamasi
{
    public partial class Form1 : Form
    {
        private string[,] dizi; // Kullan�c�dan al�nacak diziyi tutmak i�in bir de�i�ken

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullan�c�n�n girdi�i sat�r ve s�tun say�lar�n� al
            int satirSayisi, sutunSayisi;

            if (!int.TryParse(textBox1.Text, out satirSayisi) || satirSayisi <= 0)
            {
                MessageBox.Show("Ge�ersiz sat�r say�s�! L�tfen pozitif bir tam say� girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBox2.Text, out sutunSayisi) || sutunSayisi <= 0)
            {
                MessageBox.Show("Ge�ersiz s�tun say�s�! L�tfen pozitif bir tam say� girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kullan�c� taraf�ndan belirlenen boyutta bir dizi olu�tur
            dizi = new string[satirSayisi, sutunSayisi];

            // Diziyi rastgele elemanlarla doldur
            Random rnd = new Random();
            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    dizi[i, j] = rnd.Next(100).ToString(); // 0 ile 99 aras�nda rastgele say� atama
                }
            }

            // Diziyi sat�r ve s�tunlarla birlikte g�ster
            string dizigoster = "";
            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    dizigoster += "[" + i + "]" + "[" + j + "]: " + dizi[i, j] + "\t";
                }
                dizigoster += Environment.NewLine;
            }
            MessageBox.Show(dizigoster, "Dizi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Kullan�c�dan rastgele bir eleman�n konumunu sormak
            string cevap = Microsoft.VisualBasic.Interaction.InputBox("Rastgele bir eleman�n konumunu sorgulay�n (�rn: [2][3]):", "Eleman Sorgulama", "");

            // Kullan�c�n�n girdi�i konuma g�re cevab�n do�ru olup olmad���n� kontrol et
            if (cevap.Length >= 5 && cevap[0] == '[' && char.IsDigit(cevap[1]) && cevap[2] == ']' && cevap[3] == '[' && char.IsDigit(cevap[4]) && cevap[5] == ']')
            {
                int satirIndex = int.Parse(cevap[1].ToString());
                int sutunIndex = int.Parse(cevap[4].ToString());
                if (satirIndex < satirSayisi && sutunIndex < sutunSayisi)
                {
                    MessageBox.Show($"Girdi�iniz konumdaki eleman: {dizi[satirIndex, sutunIndex]}", "Cevap", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Belirtilen konum dizi boyutlar� d���nda.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ge�ersiz konum format�. L�tfen [sat�r][s�tun] �eklinde girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}