using System;
using System.Windows.Forms;

namespace WallClockApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Start the timer when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            timerClock.Start();  // Start the clock timer
        }

        // Update the label with the current time and date every second
        private void timerClock_Tick(object sender, EventArgs e)
        {
            // Get current time and date
            DateTime currentTime = DateTime.Now;

            // Format the time and date string
            labelTime.Text = currentTime.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt");
        }
    }
}
