using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cok_boyutlu_dizi_ornegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 5 satır ve 2 sütundan oluşan bir string dizi oluşturuldu
            string[,] bolgeler = new string[5, 2]
            {
                { "İstanbul","İzmit" },
                { "Ankara","Konya" },   
                { "Antalya","Adana" },   
                { "Rize","Trabzon" },    
                { "İzmir","Muğla" }      
            };

            // Dizi içindeki her bir elemanı ekrana yazdırmak için iki döngü kullanılır
            for (int i = 0; i <= bolgeler.GetUpperBound(0); i++) // Satırlar boyunca döngü
            {
                for (int j = 0; j <= bolgeler.GetUpperBound(1); j++) // Sütunlar boyunca döngü
                {
                    // İlgili satır ve sütundaki değeri ekrana yazdır
                    listBox1.Items.Add( bolgeler[i, j] ); 
                    
                }
                
                

            }
           
        }
    }
}

  