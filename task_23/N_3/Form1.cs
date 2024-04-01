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
        }

        Pen pen = new Pen(Color.Black, 2);

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(pen, new Point(100, 100), new Point(150, 50));
            g.DrawLine(pen, new Point(150, 50), new Point(350, 135));
            g.DrawLine(pen, new Point(350, 135), new Point(350, 100));
            g.DrawLine(pen, new Point(350, 100), new Point(150, 150));
            g.DrawLine(pen, new Point(150, 150), new Point(100, 100));
            g.DrawLine(pen, new Point(100, 100), new Point(130, 115));
            g.DrawEllipse(pen, 115, 90, 10, 10);

        }
    }
}
