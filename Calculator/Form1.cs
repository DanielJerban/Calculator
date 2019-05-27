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

        bool flag; 

        public frmCalculate()
        {
            InitializeComponent();
        }

        private void Numbers(object sender, EventArgs e)
        {
            if (flag == true)
            {
                txtnumber.Text = "";
                flag = false; 
            }
            txtnumber.Text += ((Button)sender).Text;
        }

        private void Operators(object sender, EventArgs e)
        {
            if (Operator != null)
            {
                btnequal_Click(null, null); 
            }
            number1 = Convert.ToDouble(txtnumber.Text);
            Operator = ((Button)sender).Text;
            flag = true; 
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
            Operator = null; 
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
            if (txtnumber.Text.Length > 0)
            {
                txtnumber.Text = txtnumber.Text.Substring(0, txtnumber.Text.Length - 1);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtnumber.Text = "";
        }

        private void btnpower_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }

        private void frmCalculate_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (Button item in panel1.Controls)
            {
                if (item.Text == e.KeyChar.ToString())
                {
                    item.Focus();
                    item.ForeColor = Color.Red; 
                }
                else
                {
                    item.ForeColor = Color.Black; 
                }
            }

            Button tmp = new Button();
            tmp.Text = e.KeyChar.ToString(); 
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                Numbers(tmp, null); 
            }
            else if (e.KeyChar == '.')
            {
                btndot_Click(tmp, null); 
            }
            else if (e.KeyChar == '/'|| e.KeyChar == '*' || e.KeyChar == '+' || e.KeyChar == '-')
            {
                Operators(tmp, null); 
            }
            else if (e.KeyChar == '=')
            {
                btnequal_Click(null, null); 
            }
            else if (e.KeyChar == '\b')
            {
                btn_Click(null, null); 
            }
        }
    }
}
