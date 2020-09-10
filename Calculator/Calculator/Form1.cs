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

    public enum Sign
    {
        Add,
        Extract,
        Multiply,
        Divide
    }

    public partial class Form1 : Form
    {
        string[] numbers = new string[2];
        private Sign Sign = Sign.Add;
        bool isSecondNumber = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnSign_Click(object sender, EventArgs e)
        {
            Button d = (Button)sender;

            string buttonText = d.Text;

            switch (buttonText)
            {
                case "+":
                    Sign = Sign.Add;
                    break;
                case "-":
                    Sign = Sign.Extract;
                    break;
                case "*":
                    Sign = Sign.Multiply;
                    break;
                case "/":
                    Sign = Sign.Divide;
                    break;
                default:
                    Sign = Sign.Add;
                    break;
            }

            txtResult.Text = string.Empty;
            isSecondNumber = true;
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            SetValue(Convert.ToInt32(((Button)sender).Text));
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                int firstNumber = Convert.ToInt32(numbers[0]);
                int secondNumber = Convert.ToInt32(numbers[1]);
                switch (Sign)
                {
                    case Sign.Add:
                        result = firstNumber + secondNumber;
                        break;
                    case Sign.Extract:
                        result = firstNumber - secondNumber;
                        break;
                    case Sign.Multiply:
                        result = firstNumber * secondNumber;
                        break;
                    case Sign.Divide:
                        result = firstNumber / secondNumber;
                        break;
                    default:
                        break;
                }

                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                txtResult.Text = string.Empty;
            }
            ClearNumbers();
            isSecondNumber = false;
        }

        private void SetValue(int number)
        {
            string newValue = txtResult.Text + number.ToString();
            txtResult.Text = newValue;

            if (!isSecondNumber)
            {
                numbers[0] = newValue;
            }
            else
            {
                numbers[1] = newValue;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearNumbers();
            txtResult.Text = string.Empty;
        }

        private void ClearNumbers()
        {
            numbers[0] = null;
            numbers[1] = null;
        }
    }
}
