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
            double loanAmount;
            if (radioButton1.Checked == true)
            {
                loanAmount = 0.00;
                label5.Text = loanAmount.ToString() ;
            }
            else if (radioButton2.Checked == true)
            {
                if (checkBox1.Checked == true)
                {

                }
            }
        }
    }
}
