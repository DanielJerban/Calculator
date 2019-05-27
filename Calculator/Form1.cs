using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculate : Form
    {
        double number1;
        double number2;
        double equal;
        string Operator;

        public frmCalculate()
        {
            InitializeComponent();
        }

        private void Numbers(object sender, EventArgs e)
        {
            txtnumber.Text += ((Button)sender).Text;
        }

        private void Operators(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtnumber.Text);
            Operator = ((Button)sender).Text;
            txtnumber.Text = "";

        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(txtnumber.Text);

            switch (Operator)
            {
                case "+":
                    equal = number1 + number2;
                    break;
                case "-":
                    equal = number1 - number2;
                    break;
                case "*":
                    equal = number1 * number2;
                    break;
                case "/":
                    equal = number1 / number2;
                    break;
            }

            txtnumber.Text = equal.ToString();
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            txtnumber.Text += ((Button)sender).Text;
        }

        private void txtnumber_TextChanged(object sender, EventArgs e)
        {
            btndot.Enabled = !txtnumber.Text.Contains(".");
            btnbackspace.Enabled = !(txtnumber.Text == "");
            btnclear.Enabled = !(txtnumber.Text == ""); 
        }

        private void btn_Click(object sender, EventArgs e)
        {
            txtnumber.Text = txtnumber.Text.Substring(0, txtnumber.Text.Length - 1);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtnumber.Text = "";
        }
    }
}
