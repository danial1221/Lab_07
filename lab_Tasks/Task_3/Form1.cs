using System;
using System.Windows.Forms;

namespace SquareCalculator
{
    public partial class Form1 : Form
    {
        // Constructor to initialize the form
        public Form1()
        {
            InitializeComponent();
        }

        // Method to calculate the square of a given number
        private int CalculateSquare(int number)
        {
            return number * number;
        }

        // Event handler for the button click
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            listBoxSquares.Items.Clear(); // Clear any previous results

            // Loop through the first 10 numbers (1 to 10)
            for (int i = 1; i i <= 10; i++)
            {
                // Call CalculateSquare method to calculate the square
                int square = CalculateSquare(i);

                // Display the result in the ListBox
                listBoxSquares.Items.Add($"Square of {i} is {square}");
            }
        }
    }
}
