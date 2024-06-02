using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secim;
             bool cevap1, cevap2;
             secim = listBox1.SelectedItem.ToString();
             cevap1 = radioButton1.Checked;
             cevap2 = radioButton2.Checked;
             if(cevap1==true && (secim=="MP4" || secim=="MOV" ))
             {
                MessageBox.Show("Cevabınız Doğru");
             }
             if (cevap1 == false && (secim == "MP4" || secim == "MOV"))
             {
                MessageBox.Show("Cevabınız Yanlış");
             }
             if (cevap2 == true && (secim == "JPG" || secim == "PNG"))
             {
                MessageBox.Show("Cevabınız Doğru");
             }
             if (cevap2 == false && (secim == "JPG" || secim == "PNG"))
             {
                MessageBox.Show("Cevabınız Yanlış");
             }
        }
    }
}
