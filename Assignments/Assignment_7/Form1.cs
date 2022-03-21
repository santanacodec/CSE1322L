using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double P;
            double interest = comboBox1.SelectedIndex;
            if (radioButton1.Checked == true)
            {
                P = 0.00;
                label5.Text = P.ToString() ;
            }
            else if (radioButton2.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    interest = Convert.ToDouble(comboBox1.SelectedIndex) - .0025;
                }

                else if (checkBox2.Checked == true)
                {
                    interest = Convert.ToDouble(comboBox1.SelectedIndex) - .0025;
                }
                else if (checkBox1.Checked == true && checkBox2.Checked == true)
                {
                    interest = Convert.ToDouble(comboBox1.Items) - .0050;
                }

                P = interest * Double.Parse(textBox1.Text) /
                    1 - Math.Pow((1 + interest), - listBox1.SelectedIndex);
                label5.Text = P.ToString();
            }
            
        }
    }
}
