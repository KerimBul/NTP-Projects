using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cinsiyet;
            if (textBox1.Text.Length<11)
            {
                MessageBox.Show("girdiğiniz değer 11 karakter olmalı");
            }
            else
            {
                listBox1.Items.Add("_____PERSONEL BİLGİLERİ____");
                listBox1.Items.Add("TC NUMARASI: " + textBox1.Text);
                listBox1.Items.Add("Adı Soyadı:" + textBox2.Text + " " + textBox3.Text);

                if (radioButton1.Checked == true)
                    cinsiyet = "erkek";
                else cinsiyet = "kadın";
                listBox1.Items.Add("Cinsiyet:" + cinsiyet);
                listBox1.Items.Add("Kan Grubu:" + comboBox1.SelectedItem);
                listBox1.Items.Add("Medeni Hal: " + comboBox2.SelectedItem);
                listBox1.Items.Add("Ünvanı:" + comboBox3.SelectedItem);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                if (radioButton1.Checked == true) radioButton1.Checked = false;
                if (radioButton2.Checked == true) radioButton2.Checked = false;
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;

            }
        }
    }
}
