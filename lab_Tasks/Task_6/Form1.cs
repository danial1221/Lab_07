using System;
using System.Windows.Forms;

namespace CountdownTimerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Try parsing the input time
            if (int.TryParse(textBoxSeconds.Text, out int time) && time > 0)
            {
                // Set the remaining time and update the label
                remainingTime = time;
                labelCountdown.Text = $"Time remaining: {remainingTime} seconds";

                // Start the countdown timer
                countdownTimer.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number.");
            }
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            // Decrement the remaining time
            remainingTime--;

            // Update the label with the current time
            labelCountdown.Text = $"Time remaining: {remainingTime} seconds";

            // When time is up, stop the timer and show the message box
            if (remainingTime == 0)
            {
                countdownTimer.Stop();
                MessageBox.Show("Time's up!");
                labelCountdown.Text = ""; // Clear the countdown label
            }
        }
    }
}
