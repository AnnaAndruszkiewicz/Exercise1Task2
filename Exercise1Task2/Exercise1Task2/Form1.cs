using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(aTextBox.Text);
            int b = Int32.Parse(bTextBox.Text);
            int c = Int32.Parse(cTextBox.Text);

            int delta = (b * b) + (-4 * a * c);

            if (delta < 0){
                equal.Text = "Non roots";
            }
            else {
                if (delta == 0)
                {
                    equal.Text = "x0 = " + (-b / (2 * a));
                }
                else
                {
                    equal.Text = "x1 = " + ((-b - Math.Sqrt(delta)) / (2 * a)) + "\nx2 = " + ((-b + Math.Sqrt(delta)) / (2 * a));
                }
            }
        }
    }
}
