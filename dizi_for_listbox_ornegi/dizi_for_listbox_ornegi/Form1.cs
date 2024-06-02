using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizi_for_listbox_ornegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] diziKaynak = new int[100];
        int[] diziKopya = new int[100];
        

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Random rastgele = new Random();
                for (int i = 0; i < diziKaynak.Length; i++)
                {
                    diziKaynak[i] = rastgele.Next(0, 101);
                }
                for (int i = 0; i < diziKaynak.Length; i++)
                {
                    listBox1.Items.Add(diziKaynak[i]);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < diziKopya.Length; i++) 
            {
                diziKopya[i] = diziKaynak[i];
             }
        
            for (int i = 0; i < diziKopya.Length; i++)
            {
                listBox2.Items.Add(diziKopya[i]);
            }
        }

        
    }
}

