using System;
using System.IO;
using System.Windows.Forms;

namespace N_4
{   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            radioButton3.Checked = true;
            radioButton8.Checked = true;

            comboBox1.Text = "1";
            comboBox2.Text = "Январь";
            comboBox3.Text = "2000";

            domainUpDown1.Text = "0";
            domainUpDown2.Text = "100";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;

            radioButton1.Checked = true;
            comboBox1.Text = "1";
            comboBox2.Text = "Январь";
            comboBox3.Text = "2000";

            comboBox4.Text = string.Empty;
            textBox4.Text = string.Empty;
            comboBox6.Text = string.Empty;
            textBox5.Text = string.Empty;

            radioButton3.Checked = true;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

            domainUpDown1.Text = "0";
            domainUpDown2.Text = "100";

            radioButton8.Checked = true;
            textBox6.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                sw.WriteLine(textBox1.Text);
                sw.WriteLine(textBox2.Text);
                sw.WriteLine(textBox3.Text);

                if(radioButton1.Checked)
                {
                    sw.WriteLine("Мужчина");
                }
                else
                {
                    sw.WriteLine("Женщина");
                }

                sw.WriteLine($"{comboBox1.Text} {comboBox2.Text} {comboBox3.Text}");

                sw.WriteLine(comboBox4.Text);
                sw.WriteLine(textBox4.Text);
                sw.WriteLine($"{comboBox6.Text} {textBox5.Text}");

                if (radioButton3.Checked)
                {
                    sw.WriteLine("Прежде не работал");
                }
                else if (radioButton4.Checked)
                {
                    sw.WriteLine("Меньше года");
                }
                else if (radioButton5.Checked)
                {
                    sw.WriteLine("От 1 до 5");
                }
                else if (radioButton6.Checked)
                {
                    sw.WriteLine("От 5 до 9");
                }
                else
                {
                    sw.WriteLine("Более 10");
                }

                sw.WriteLine(textBox6.Text);
            }
        }
    }
}
