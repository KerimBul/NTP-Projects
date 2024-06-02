<<<<<<< HEAD
namespace diziler_dama_tahtasi_olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Satranç Tahtasý";
            Button[,] button = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Width = 70;
                    button[i, j].Height = 70;
                    button[i, j].Left = left;
                    button[i, j].Top = top;
                    this.Controls.Add(button[i, j]);
                    left += 70;
                    if ((i + j) % 2 == 0)
                    {
                        button[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        button[i, j].BackColor = Color.White;
                    }
                }
                top += 70;
                left = 0;
            }

        }
    }
}
=======
ï»¿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler_dama_tahtasi_olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "SatranÃ§ TahtasÄ±";
            Button[,] button = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Width = 70;
                    button[i, j].Height = 70;
                    button[i, j].Left = left;
                    button[i, j].Top = top;
                    this.Controls.Add(button[i, j]);
                    left += 70;
                    if ((i + j) % 2 == 0)
                    {
                        button[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        button[i, j].BackColor = Color.White;
                    }
                }
                top += 70;
                left = 0;
            }

        }
    }
}
>>>>>>> d35a5fc8d7f4940d68b939e7d090bb96659fa509
