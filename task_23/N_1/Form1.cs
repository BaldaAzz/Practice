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

        private void button1_Click(object sender, EventArgs e)
        {
            string inputStr = (string)listBox1.Items[0];

            string[] words = inputStr.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1)
                {
                    words[i] = words[i].Substring(1);
                }
                else
                {
                    words[i] = "";
                }
            }

           label1.Text = string.Join(" ", words);
        }
    }
}
