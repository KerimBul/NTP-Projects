using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liste_kullanimi
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
            
            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sehirler.Add("Adana");
            sehirler.Add("İstanbul");
            Listele();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int secili = listBox1.SelectedIndex;
            sehirler.RemoveAt(secili);
        }
    }
}
