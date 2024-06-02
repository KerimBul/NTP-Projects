using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomIsimAtama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int sayi = random.Next(0, listBox1.Items.Count); // Listbox içinden rastgele bir indeks seç
            textBox1.Text = listBox1.Items[sayi].ToString(); // Seçilen indeksteki elemanı textBox'a ata
            this.BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
        }

    }
}
