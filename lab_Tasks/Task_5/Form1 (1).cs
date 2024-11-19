using System;
using System.Windows.Forms;

namespace FactorialCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Method to calculate factorial
        private long CalculateFactorial(int number)
        {
            if (number == 0 || number == 1)
                return 1;  // Base case: factorial of 0 or 1 is 1
            else
                return number * CalculateFactorial(number - 1);  // Recursive case
        }

        // Button click event handler to calculate factorial
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Get the input number from the TextBox
            if (int.TryParse(textBoxInput.Text, out int number) && number >= 0)
            {
                // Calculate the factorial using the method
                long result = CalculateFactorial(number);

                // Display the result in the label
                labelResult.Text = $"The factorial of {number} is: {result}";
            }
            else
            {
                // Show error message if input is invalid
                MessageBox.Show("Please enter a valid non-negative number.");
            }
        }
    }
}
