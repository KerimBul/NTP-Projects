using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace diziler_sesli_harf_sayisi_uygulamasi
{
    public partial class Form1 : Form
    {
        private string[,] dizi; // Kullanýcýdan alýnacak diziyi tutmak için bir deðiþken

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanýcýnýn girdiði satýr ve sütun sayýlarýný al
            int satirSayisi, sutunSayisi;

            if (!int.TryParse(textBox1.Text, out satirSayisi) || satirSayisi <= 0)
            {
                MessageBox.Show("Geçersiz satýr sayýsý! Lütfen pozitif bir tam sayý girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBox2.Text, out sutunSayisi) || sutunSayisi <= 0)
            {
                MessageBox.Show("Geçersiz sütun sayýsý! Lütfen pozitif bir tam sayý girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kullanýcý tarafýndan belirlenen boyutta bir dizi oluþtur
            dizi = new string[satirSayisi, sutunSayisi];

            // Diziyi rastgele elemanlarla doldur
            Random rnd = new Random();
            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    dizi[i, j] = rnd.Next(100).ToString(); // 0 ile 99 arasýnda rastgele sayý atama
                }
            }

            // Diziyi satýr ve sütunlarla birlikte göster
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

            // Kullanýcýdan rastgele bir elemanýn konumunu sormak
            string cevap = Microsoft.VisualBasic.Interaction.InputBox("Rastgele bir elemanýn konumunu sorgulayýn (örn: [2][3]):", "Eleman Sorgulama", "");

            // Kullanýcýnýn girdiði konuma göre cevabýn doðru olup olmadýðýný kontrol et
            if (cevap.Length >= 5 && cevap[0] == '[' && char.IsDigit(cevap[1]) && cevap[2] == ']' && cevap[3] == '[' && char.IsDigit(cevap[4]) && cevap[5] == ']')
            {
                int satirIndex = int.Parse(cevap[1].ToString());
                int sutunIndex = int.Parse(cevap[4].ToString());
                if (satirIndex < satirSayisi && sutunIndex < sutunSayisi)
                {
                    MessageBox.Show($"Girdiðiniz konumdaki eleman: {dizi[satirIndex, sutunIndex]}", "Cevap", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Belirtilen konum dizi boyutlarý dýþýnda.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Geçersiz konum formatý. Lütfen [satýr][sütun] þeklinde girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}