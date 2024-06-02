using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // İlk ListBox'ı temizle
            listBox2.Items.Clear(); // İkinci ListBox'ı temizle
            listBox3.Items.Clear(); // Üçüncü ListBox'ı temizle

            int baslangic = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);

            int i = baslangic;

            do
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    listBox1.Items.Add(i); // 3'e ve 5'e bölünenleri birinci ListBox'a ekle
                }
                if (i % 7 == 0)
                {
                    listBox2.Items.Add(i); // 7'ye bölünenleri ikinci ListBox'a ekle
                }
                if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                {
                    listBox3.Items.Add(i); // Hem 3'e, 5'e hem de 7'ye bölünenleri üçüncü ListBox'a ekle
                }
                i++;
            } while (i <= bitis);
        }
        }
    }

