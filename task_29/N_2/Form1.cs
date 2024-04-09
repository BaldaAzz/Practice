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
        Graphics g;
        Bitmap baner;
        Rectangle rect;

        public Form1()
        {
            InitializeComponent();

            try
            {
                baner = new Bitmap(@"D:\study\C#_Practice\Practice\task_29\N_2\baner.jpg");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка загрузки банера \n" + e.Message.ToString());
                this.Close();
                return;
            }

            rect.X = 0;
            rect.Y = 0;
            rect.Width = baner.Width;
            rect.Height = baner.Height;

            timer1.Interval = 50;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rect.X -= 1;

            if (Math.Abs(rect.X) > rect.Width)
                rect.X += rect.Width;

            for (int i = 0; i <= Convert.ToInt16(this.ClientSize.Width / rect.Width) + 1; i++)
                g.DrawImage(baner, rect.X+i*rect.Width, rect.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if((e.Y < rect.Y + rect.Height) && (e.Y > rect.Y))
            {
                if (timer1.Enabled != false)
                    timer1.Enabled = false;
            }
            else
            {
                if (timer1.Enabled != true)
                    timer1.Enabled = true;
            }
        }
    }
}
