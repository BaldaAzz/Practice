using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private double CalculateFunc(Func<double, double> func, double x, double y)
        {
            double value = func(x);

            if (x > Math.Abs(y))
            {
                return 2 * Math.Pow(value, 3) + 3 * Math.Pow(y, 3);
            }
            else if (x == Math.Abs(y))
            {
                return Math.Pow(value - y, 2);
            }
            else
            {
                return Math.Abs(value - y);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double result = 0;

            if (radioButton1.Checked)
            {
                result = CalculateFunc((double arg) => Math.Sinh(arg), x, y);
            }
            else if (radioButton2.Checked)
            {
                result = CalculateFunc((double arg) => Math.Pow(arg, 2), x, y);
            }
            else if (radioButton3.Checked)
            {
                result = CalculateFunc((double arg) => Math.Pow(Math.E, x), x, y);
            }

            textBox4.Text = $"Результат: {result}";
        }
    }
}
