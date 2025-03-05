using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JurnalModul3_103022300072
{
    public partial class Form1 : Form
    {
        int angka = 0;
        int jumlah = 0;
        string operasi = "";
        string hasil = "";
        bool lebihdari1 = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!lebihdari1)
            {
                angka = 1;
                lebihdari1 = true;
            } else
            {
                angka = (angka*10) + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!lebihdari1)
            {
                angka = 2;
                lebihdari1 = true;
            }
            else
            {
                angka = (angka * 10) + 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!lebihdari1)
            {
                angka = 3;
                lebihdari1 = true;
            }
            else
            {
                angka = (angka * 10) + 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!lebihdari1)
            {
                angka = 4;
                lebihdari1 = true;
            }
            else
            {
                angka = (angka * 10) + 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!lebihdari1)
            {
                angka = 5;
                lebihdari1 = true;
            }
            else
            {
                angka = (angka * 10) + 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!lebihdari1)
            {
                angka = 6;
                lebihdari1|= true;
            }
            else
            {
                angka = (angka * 10) + 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!lebihdari1)
            {
                angka = 7;
                lebihdari1 = true;
            }
            else
            {
                angka = (angka * 10) + 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!lebihdari1)
            {
                angka = 8;
                lebihdari1 = true;
            }
            else
            {
                angka = (angka * 10) + 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!lebihdari1)
            {
                angka = 9;
                lebihdari1 = true;
            }
            else
            {
                angka = (angka * 10) + 9;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!lebihdari1)
            {
                angka = 0;
                lebihdari1 = true;
            }
            else
            {
                angka = (angka * 10) + 0;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            jumlah += angka;
            operasi += angka;
            label1.Text = operasi;
            angka = 0;
            lebihdari1 = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            jumlah += angka;
            operasi += angka;
            label1.Text = operasi;
            hasil += "" + jumlah;
            label1.Text = hasil;
            jumlah = 0;
            angka = 0;
            lebihdari1 = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
