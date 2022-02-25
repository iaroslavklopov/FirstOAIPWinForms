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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            int m = 9;
            int n = 9;
            int[,] arr = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(10, 100);
                    textBox1.Text = textBox1.Text + arr[i, j].ToString() + " ";
                }
                textBox1.Text += "\n";
            }
            textBox1.Text += "\n";
            int[] min = new int[m];
            int s = 0;
            for (int i = 0; i < m; i++)
            {
                int k = arr[i, 0];
                for (int j = 0; j < n; j++)
                {
                    if (k < arr[i, j])
                        k = arr[i, j];
                }
                min[s] = k;
                s++;
            }
            int max = min[0];
            for (int i = 0; i < min.Length; i++)
                if (max > min[i])
                    max = min[i];
            label1.Text = "Наименьшее из наибольших - " + max;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Perexodnik perexodnik = new Perexodnik();
            perexodnik.Show();
            perexodnik.Hide();
        }
    }
}
