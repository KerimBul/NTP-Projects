using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizi_foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

                private void button1_Click(object sender, EventArgs e)
                {
                     // String dizisi oluşturup elemanları ekleyelim
            string[] dizi = new string[5];
            dizi[0] = "Buse";
            dizi[1] = "Evin";
            dizi[2] = "Gamze";
            dizi[3] = "Doni";
            dizi[4] = "Badi";

            // Her bir elemanı ekranda göstermek için foreach döngüsü kullanalım
            foreach (string eleman in dizi)
            {
                listBox1.Items.Add(eleman);
            }
        }
                }
    }


