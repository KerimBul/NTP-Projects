using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosyaBulunamadiHatasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "C:/Users/Administrator/Desktop/NTP/Manav";
            if ( System.IO.File.Exists(filePath))
            {
                MessageBox.Show("Dosyanız bulundu. "); 
            }
            else
            {
                try
                {

                    System.IO.File.OpenRead(filePath); //Burada dosya okunur
                }
                catch (System.IO.FileNotFoundException ex) // dosya bulunamadı hatası
                {
                    MessageBox.Show("Dosyanız bulunmadı. " + ex.Message);
                }
            }
            }
            
    }
}
