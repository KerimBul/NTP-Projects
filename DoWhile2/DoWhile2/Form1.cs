﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoWhile2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            do
            {
                MessageBox.Show("Döngü Çalışıyor.");
                if (a == 5)
                {
                    MessageBox.Show("Döngü Durdu.");
                    break;
                }
                a++;
            } while (a < 10);
            }
    }
}   
