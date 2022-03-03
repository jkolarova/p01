using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            
            label1.Text = (x + y).ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            
            label2.Text = (x - y).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zbztek po 10/7 je " +AritOp.Zbytek(10, 7));
        }
    }
}
