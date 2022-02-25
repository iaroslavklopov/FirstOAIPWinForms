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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static bool CheckNumber(int num)
        {
            int sum = 1;
            for (int i = 2; i < num / 2 + 1; i++) if (num % i == 0) sum += i;
            return (sum == num);
        }
        private void button1_Click(object sender, EventArgs e)
        {
                int Number = 0;

                Number = Convert.ToInt32(textBox1.Text);

            if (CheckNumber(Number))
            {
                label2.Text = "Совершенное";
            }
            else
            {
                label2.Text = "Не совершенное";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Perexodnik perexodnik = new Perexodnik();
            perexodnik.Show();
            this.Hide();
        }
    }
}
