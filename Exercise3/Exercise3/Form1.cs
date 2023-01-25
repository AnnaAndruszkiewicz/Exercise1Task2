using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (.txt)|*.txt";
            ofd.Title = "Open a file...";

            if (ofd.ShowDialog() == DialogResult.OK) {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "Text File (.txt)|*.txt";
            svf.Title = "Save file...";

            if (svf.ShowDialog() == DialogResult.OK) { 
                System.IO.StreamWriter sw = new System.IO.StreamWriter(svf.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult fr = fontDialog1.ShowDialog();

            if (fr == DialogResult.OK) {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cr = colorDialog1.ShowDialog();

            if (cr == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }
    }
}
