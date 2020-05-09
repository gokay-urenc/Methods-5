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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] oo = new object[3];
            oo[0] = 'C';
            oo[1] = "Hello";
            oo[2] = 98.4;
            object deneme = oo; // Boxing işlemi.
            string hello = (string)deneme;
            // string hello = (string)deneme[1]; // Hatalı işlem olur.
            object[] denemeyi_oku = (object[])deneme; // Unboxing işlemi.
            string hello_2 = denemeyi_oku[1].ToString();
            double d = (double)denemeyi_oku[2];
        }
    }
}