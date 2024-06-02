using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte sinif;
             sinif = Convert.ToByte(comboBox1.Text);
             if (sinif > 0 && sinif < 5)
             {
                MessageBox.Show("İlkokul kademesi");
             }
             else if (sinif > 4 && sinif < 9)
             {
                MessageBox.Show("Ortaokul kademesi");
             }
             else if (sinif > 8 && sinif < 13)
             {
                MessageBox.Show("Lise kademesi");
             }
        }
    }
}
