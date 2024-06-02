using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5]; // 5 elemanlı dizi tanımlandı
        int[] notlar = new int[5];
        //Global dizi
        int index = 0;
        //Global değişken

        private void button1_Click(object sender, EventArgs e)
        {
             if(index<isimler.Length)
                {
                     isimler[index] = textBox1.Text;
                     notlar[index] = Convert.ToInt32(textBox2.Text);
        // int.Parse fonksiyonu girilen değeri “int” veri türüne dönüştürür
                    index++;
                    textBox1.Text = "";
                    textBox2.Text = "";
        }
    }

        private void button2_Click(object sender, EventArgs e)
        {
             for (int i = 0; i < isimler.Length; i++)
             {
            if(isimler[i] != null)
                 {
                    listBox1.Items.Add(isimler[i]+" > "+notlar[i]);
                 }
 }
        }
    }
}
