using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control c = new Control();

            if(textBox1.Text == "К")
            {
                c = new Button();
                c.Text = "Кнопка";
            }
            else if (textBox1.Text == "М")
            {
                c = new Label();
                c.Text = "Метка";
            }
            else if (textBox1.Text == "П")
            {
                c = new TextBox();
                c.Text = "Поле";
            }
            else
            {
                return;
            }

            c.Parent = this;
            c.Location = new Point(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
        }
    }
}
