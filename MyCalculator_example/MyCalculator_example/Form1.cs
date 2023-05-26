using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator_example
{
    public partial class Form1 : Form
    {
        ICalculate Calculate;

        public Form1()
        {
            InitializeComponent();
            Calculate = new Calculate();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int sum = Calculate.Plus((int)txtNumber1.Value,(int)txtNumber2.Value);
                MessageBox.Show("Sum Is : " + sum );
            }
        }

        bool ValidateInputs()
        {
            bool isValid = true;
            if (txtNumber1.Value == 0)
            {
                isValid = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید");
            }

            else
            {
                if (txtNumber2.Value == 0 )
                {
                    isValid = false;
                    MessageBox.Show("لطفا عدد دوم را وارد کنید");
                }

            }
            return isValid;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int Minus = Calculate.Minus(int.Parse(txtNumber1.Value.ToString()), int.Parse(txtNumber2.Value.ToString()));
                MessageBox.Show("Minus Is : " + Minus);
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int Multiple = Calculate.Multiple((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Multiple Is : " + Multiple);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int Divide = Calculate.Divide((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Divide Is : " + Divide);
            }
        }
    }
}
