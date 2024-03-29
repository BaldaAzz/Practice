using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected void EnabledButton(bool input)
        {
            button2.Enabled = input;
            button3.Enabled = input;
            button4.Enabled = input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.EnabledButton(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.EnabledButton(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.EnabledButton(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.EnabledButton(false);
        }
    }
}
