using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p, massint, o, res;
            p = 0;
            o = 0;
            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            int[] mass1Int = new int[n];
            for (int i = 0; i < n; i++)
            {
                mass1Int[i] = rnd.Next(-100, 100);
                textBox2.Text = textBox2.Text + mass1Int[i].ToString() + " ";
            }
            textBox2.Text += "\n";
            for (int i = 0; i < n; i++)
            {
                if (mass1Int[i] < 0)
                {
                    massint = mass1Int[i] * (-1);
                    p = p + massint;
                }
                if (mass1Int[i] > 0)
                {
                    o = o + mass1Int[i];
                }
            }
            if (p > o)
            {
                res = p - o;
            }
            else
            {
                res = o - p;
            }
            label2.Text = "Sum = " + res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Perexodnik perexodnik = new Perexodnik();
            perexodnik.Show();
            this.Hide();
        }
    }
}
