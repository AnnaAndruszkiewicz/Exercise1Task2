using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        int x, y, width, height;  

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            height= e.X - x;
            width= e.Y - y;

            Graphics g = this.CreateGraphics();

            Color color;

            if (Black.Checked)
            {
                color= Color.Black;
            }
            else if (Red.Checked)
            {
                color= Color.Red;
            }
            else
            { 
                color= Color.Blue;
            }

            Pen p= new Pen(color, 2);

            if (Eclipse.Checked)
            {
                g.DrawEllipse(p, x, y, width, height);
            }
            else if (Circle.Checked)
            {
                g.DrawEllipse(p, x, y, width, width);
            }
            else if (Line.Checked)
            {
                g.DrawLine(p, x, y, e.X, e.Y);
            }
            else if (Rectangle.Checked)
            {
                g.DrawRectangle(p, x, y, width, height);
            }
            else if (Polygon.Checked) 
            {

            }
        }
    }
}
