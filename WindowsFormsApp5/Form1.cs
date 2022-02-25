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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            if (a % 2 == 1)
            {
                label3.Text = "Нечётное";

            }
            else
            {
                label3.Text = "Чётное";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox2.Text);
            if (b % 2 == 1)
            {
                label4.Text = "Нечётное";

            }
            else
            {
                label4.Text = "Чётное";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Perexodnik perexodnik = new Perexodnik();
            perexodnik.Show();
            this.Hide();
        }
    }
}
