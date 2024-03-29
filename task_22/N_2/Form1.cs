using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = Convert.ToString(1.825*Math.Pow(10,2));
            textBox2.Text = Convert.ToString(18.225);
            textBox3.Text = Convert.ToString(-3.298 * Math.Pow(10, -2));
        }

        private double CalculateFunc(double x, double y, double z)
        {
            double exp1 = Math.Abs(Math.Pow(x, y/x) - Math.Pow(x/y, 1/3));
            double exp2 =(y-x)*((Math.Cos(y)-z/(y-x))/(1+Math.Pow(y-x, 2)));
            return exp1 + exp2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);

            textBox4.Text = $"Результат: {CalculateFunc(x, y, z)}";
        }
    }
}
