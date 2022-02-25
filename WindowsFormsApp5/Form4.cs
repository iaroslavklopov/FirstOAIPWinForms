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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);

            double x1, x2;
            //дискриминант
            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
            {
               label4.Text = "Квадратное уравнение не имеет корней";
            }
            else
            {
                if (discriminant == 0) //квадратное уравнение имеет два одинаковых корня
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                }
                else //уравнение имеет два разных корня
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                }
                //вывод корней уравнения
                label4.Text = $"x1 = {x1}; x2 = {x2}";
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
