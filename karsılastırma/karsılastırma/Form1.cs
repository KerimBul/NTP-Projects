using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karsılastırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int not = Convert.ToInt32(textBox1.Text);

            if (not>= 10 && not< 50  )
            {
                MessageBox.Show("Sorumlu Geçtiniz");
            }
            if (not>=0 && not< 10)
            {
                MessageBox.Show("Sınıfta Kaldınız.");
            }
            if (not >= 50 && not < 100)
            {
                MessageBox.Show("Tebrikler geçtiniz.");
            }
            
        }
    }
}
