using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        int label1Count = 0;
        int label2Count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Button 1 pressed " + ++label1Count + " times";
            label3.Text = "Button1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Button 2 pressed " + ++label2Count + " times";
            label3.Text = "Button2";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
