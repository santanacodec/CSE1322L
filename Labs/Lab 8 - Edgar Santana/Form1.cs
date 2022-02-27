using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8___Edgar_Santana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(textBox1.Text);
            int input2 = int.Parse(textBox2.Text);

            int output = input1 + input2;

            label1.Text = output.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
        }
    }
}
