using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private double _firstNumber;
        private double _secondNumber;
        private string _operation;

        public Form1()
        {
            InitializeComponent();
        }

        // Event for number buttons (0-9)
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxResult.Text += button.Text;
        }

        // Event for operation buttons (+, -, *, /)
        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _firstNumber = Convert.ToDouble(textBoxResult.Text);
            _operation = button.Text;
            textBoxResult.Clear();
        }

        // Event for Equals button (=)
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            _secondNumber = Convert.ToDouble(textBoxResult.Text);
            switch (_operation)
            {
                case "+":
                    textBoxResult.Text = (_firstNumber + _secondNumber).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (_firstNumber - _secondNumber).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (_firstNumber * _secondNumber).ToString();
                    break;
                case "/":
                    if (_secondNumber != 0)
                    {
                        textBoxResult.Text = (_firstNumber / _secondNumber).ToString();
                    }
                    else
                    {
                        textBoxResult.Text = "Error";
                    }
                    break;
            }
        }

        // Event for Clear button (C)
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            _firstNumber = 0;
            _secondNumber = 0;
            _operation = string.Empty;
        }
    }
}
