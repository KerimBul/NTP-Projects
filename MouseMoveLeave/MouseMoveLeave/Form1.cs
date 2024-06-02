using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMoveLeave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Üzerimde");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
