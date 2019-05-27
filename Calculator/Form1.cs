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

        //private void Numbers(object sender, EventArgs e)
        //{
        //    if (flag == true)
        //    {
        //        txtnumber.Text = "";
        //        flag = false; 
        //    }
        //    txtnumber.Text += ((Button)sender).Text;
        //}

        private void Numbers_MouseClick(object sender, MouseEventArgs e)
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
            if (txtnumber.Text != "")
            {
                number2 = Convert.ToDouble(txtnumber.Text);
            }

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

        //private void btndot_Click(object sender, EventArgs e)
        //{
        //    txtnumber.Text += ((Button)sender).Text;
        //}

        private void btndot_MouseClick(object sender, MouseEventArgs e)
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
            
        }

        private void frmCalculate_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (Button item in panel1.Controls)
            {
                if (item.Text == e.KeyChar.ToString())
                {
                    item.Focus();
                }
            }

            Button tmp = new Button();
            tmp.Text = e.KeyChar.ToString(); 
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                Numbers_MouseClick(tmp, null); 
            }
            else if (e.KeyChar == '.')
            {
                btndot_MouseClick(tmp, null); 
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

        private void frmCalculate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnequal_Click(null, null);
                btnequal.Focus(); 
            }
        }

        private void btnpower_Click(object sender, EventArgs e)
        {
            foreach (Button item in panel1.Controls)
            {
                if (item.Enabled == true)
                {
                    item.Enabled = false;
                    btnbackspace.Enabled = false;
                    btnbackspace.Enabled = false;
                    btnclear.Enabled = false;
                    this.KeyPreview = false;
                    btnpower.Text = "ON";
                }
                else
                {
                    item.Enabled = true;
                    btnbackspace.Enabled = true;
                    btnclear.Enabled = true;
                    this.KeyPreview = true;
                    btnpower.Text = "OFF";
                }
            }
        }
    }
}
