using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataAyiklama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                int sayi1, sayi2,sonuc;
                    sayi1= 10;
                    sayi2 = 0;
                 sonuc = sayi1/sayi2;
            }
            catch (System.DivideByZeroException ex)
            {
                MessageBox.Show("Sayı sıfıra bölünemez " + ex.Message);

            }
           
        }
    }
}
