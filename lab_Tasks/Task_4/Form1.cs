using System;
using System.Windows.Forms;

namespace FahrenheitToCelsiusConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  // This initializes the components defined in the Designer
        }

        // Method to convert Fahrenheit to Celsius
        private double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        // Event handler for button click
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            // Try to parse the entered Fahrenheit value
            if (double.TryParse(textBoxFahrenheit.Text, out double fahrenheit))
            {
                // Call the conversion method and get the Celsius value
                double celsius = ConvertFahrenheitToCelsius(fahrenheit);

                // Display the result in the label
                labelResult.Text = $"Celsius: {celsius:F2}"; // Showing 2 decimal places
            }
            else
            {
                // If input is invalid, show an error message
                MessageBox.Show("Please enter a valid Fahrenheit value.");
            }
        }
    }
}
