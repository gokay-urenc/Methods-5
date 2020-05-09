using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodlar_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc = Toplama(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox3.Text = sonuc.ToString();

        }

        int Toplama(int sayi1, int sayi2)
        {
            int toplam_sonucu = sayi1 + sayi2;
            return toplam_sonucu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sonuc = Fark(Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox5.Text));
            textBox4.Text = sonuc.ToString();
        }

        int Fark(int sayi1, int sayi2)
        {
            int fark_sonuc = sayi1 - sayi2;
            return fark_sonuc;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal sonuc = Kuvvet(Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox8.Text));
            textBox7.Text = sonuc.ToString();
        }

        decimal Kuvvet(int sayi, int kuvvet)
        {
            decimal kuvvet_sonuc = 1;
            for (int i = 0; i < kuvvet; i++)
            {
                kuvvet_sonuc = kuvvet_sonuc * sayi;
            }
            return kuvvet_sonuc;
        }
    }
}