using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sum_Or_Triple_Sum_and_check_30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int result = SumOrTripleSum(num1, num2);
            txResultSum.Text =  result.ToString();
        }

        private int SumOrTripleSum(int num1, int num2)
        {
            if (num1 == num2)
            {
                return 3 * (num1 + num2);
            }
            else
            {
                return num1 + num2;
            }
        }

         private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            bool result = Check30(num1, num2);
            txtResultCheck.Text = result.ToString();
        }

        private bool Check30(int num1, int num2)
        {
            return (num1 == 30 || num2 == 30 || (num1 + num2) == 30);
        }
    }

}

