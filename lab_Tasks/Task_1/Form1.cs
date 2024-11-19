using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtNum1.Text);
                double num2 = Convert.ToDouble(txtNum2.Text);
                string operation = cmbOperation.SelectedItem.ToString();
                double result = 0;

                switch (operation)
                {
                    case "Add":
                        result = Add(num1, num2);
                        break;
                    case "Subtract":
                        result = Subtract(num1, num2);
                        break;
                    case "Multiply":
                        result = Multiply(num1, num2);
                        break;
                    case "Divide":
                        if (num2 == 0)
                        {
                            MessageBox.Show("Cannot divide by zero.");
                            return;
                        }
                        result = Divide(num1, num2);
                        break;
                }

                lblResult.Text = "Result: " + result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private double Add(double a, double b) => a + b;

        private double Subtract(double a, double b) => a - b;

        private double Multiply(double a, double b) => a * b;

        private double Divide(double a, double b) => a / b;

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
