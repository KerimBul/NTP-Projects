using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
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
            while(i<10)
            {
                i++;
                if(i==5)
                {
                    MessageBox.Show("Continue");
                    continue;
                }
                MessageBox.Show("i: " +i);
                if(i==9)
                {
                    MessageBox.Show("Break");
                    break;
                }
            }
        }
    }
}
