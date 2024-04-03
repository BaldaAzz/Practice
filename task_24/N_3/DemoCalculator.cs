using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_3
{
    public partial class DemoCalculator : UserControl
    {
        private double operand1;
        private double operand2;
        private char currentOperator;

        public DemoCalculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentOperator = '+';
            label3.Text = currentOperator.ToString();
            operand1 = double.Parse(textBox1.Text);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            currentOperator = '-';
            operand1 = double.Parse(textBox1.Text);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            currentOperator = '*';
            operand1 = double.Parse(textBox1.Text);          
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            currentOperator = '/';
            operand1 = double.Parse(textBox1.Text);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            operand2 = double.Parse(textBox2.Text);
            double result = PerformCalculation(operand1, operand2, currentOperator);
            label2.Text = result.ToString();
        }

        private double PerformCalculation(double num1, double num2, char op)
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 != 0)
                        return num1 / num2;
                    else
                    {
                        MessageBox.Show("Деление на ноль недопустимо!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return double.NaN;
                    }
                default:
                    return double.NaN;
            }
        }
    }
}
