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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 1. Ödemeyi kasaya yapınız.");
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 2. Ödemeyi kasaya yapınız.");
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 3. Ödemeyi kasaya yapınız.");
            }
            if (radioButton4.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 4. Ödemeyi kasaya yapınız.");
            }
            if (radioButton5.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 5. Ödemeyi kasaya yapınız.");
            }
            if (radioButton6.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 6. Ödemeyi kasaya yapınız.");
            }
            if (radioButton7.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 7. Ödemeyi kasaya yapınız.");
            }
            if (radioButton8.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 8. Ödemeyi kasaya yapınız.");
            }
            if (radioButton9.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 9. Ödemeyi kasaya yapınız.");
            }
            if (radioButton10.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 10. Ödemeyi kasaya yapınız.");
            }
            if (radioButton11.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 11. Ödemeyi kasaya yapınız.");
            }
            if (radioButton12.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 12. Ödemeyi kasaya yapınız.");
            }
            if (radioButton13.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 13. Ödemeyi kasaya yapınız.");
            }
            if (radioButton14.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 14. Ödemeyi kasaya yapınız.");
            }
            if (radioButton15.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 15. Ödemeyi kasaya yapınız.");
            }
            if (radioButton16.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 16. Ödemeyi kasaya yapınız.");
            }
            if (radioButton17.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 17. Ödemeyi kasaya yapınız.");
            }
            if (radioButton18.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 18. Ödemeyi kasaya yapınız.");
            }
            if (radioButton19.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 19. Ödemeyi kasaya yapınız.");
            }
            if (radioButton20.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 20. Ödemeyi kasaya yapınız.");
            }
            if (radioButton21.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 21. Ödemeyi kasaya yapınız.");
            }
            if (radioButton22.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 22. Ödemeyi kasaya yapınız.");
            }
            if (radioButton23.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 23. Ödemeyi kasaya yapınız.");
            }
            if (radioButton24.Checked)
            {
                MessageBox.Show("Seçtiğiniz koltuk numarası 24. Ödemeyi kasaya yapınız.");
            }

            Form3 ücform = new Form3();
            ücform.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
