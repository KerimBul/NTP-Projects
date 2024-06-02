using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i<7) // i değeri 7' den küçük olduğu sürece çalışır
            {
                i++; // i değerini birer birer arttırıyoruz.
                if (i==5)
                {
                    MessageBox.Show("Continue");
                    continue; //bu işlemi atlar ve devam eder
                }
                MessageBox.Show("i: "+i); // i' nin değerini yazdırdık
                if (i==6)
                {
                    MessageBox.Show("Break");
                    break; //işlemi sonlandırır
                }
            }

        }
    }
}
