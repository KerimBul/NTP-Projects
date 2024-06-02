using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUygulamasi
{
    public partial class Kadın : Form
    {
        public Kadın()
        {
            InitializeComponent();
        }

        private void Kadın_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy = Convert.ToDouble(textBox1.Text);
            double kilo = Convert.ToDouble(textBox2.Text);
            double vki = kilo / (boy * boy);
            MessageBox.Show("Vücut Kitle Endexiniz: " + vki);
        }
    }
}
