using System;
using System.Windows.Forms;

namespace TextBoxLimitApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler to update character count as the user types
        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            // Get the current length of text in the TextBox
            int currentLength = textBoxInput.Text.Length;

            // Update the label to show the current character count
            labelCharacterCount.Text = $"Characters: {currentLength}/160";
        }

        // Event handler for the submit button (optional, just for demonstration)
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You entered: {textBoxInput.Text}");
        }

        // Form load event to initialize the character count label
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the initial character count to 0
            labelCharacterCount.Text = "Characters: 0/160";
        }
    }
}
