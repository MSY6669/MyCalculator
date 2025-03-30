using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        ICalaulate calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new calculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int Sum = calculate.plus((int)txtnum1.Value, (int)txtnum2.Value);
                MessageBox.Show("Sum Is: " + Sum, "Results", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }


        bool ValidateInputs()
        {
            bool isvalid = true;

            if (txtnum1.Value == 0)
            {
                isvalid = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید");

            }
            else
            {
                if (txtnum2.Value == 0)
                {
                    isvalid = false;
                    MessageBox.Show("لطفا عدد دوم را وارد کنید");
                }
            }
            return isvalid; 

        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int Minus = calculate.minus((int)txtnum1.Value, (int)txtnum2.Value);
                MessageBox.Show("Minus Is: " + Minus, "Results", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnzarb_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int Zarb = calculate.zarb((int)txtnum1.Value, (int)txtnum2.Value);
                MessageBox.Show("Zarb Is: " + Zarb, "Results", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btndivid_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int Divide = calculate.divide((int)txtnum1.Value, (int)txtnum2.Value);
                MessageBox.Show("Divide Is: " + Divide, "Results" ,MessageBoxButtons.OK,MessageBoxIcon.None);
            }
        }
    }
}
