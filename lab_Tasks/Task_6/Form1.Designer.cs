using System;
using System.Windows.Forms; // Required for Windows Forms controls like TextBox, Button, Timer, Label

namespace CountdownTimerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelInstruction;
        private TextBox textBoxSeconds;
        private Button buttonStart;
        private Label labelCountdown;
        private Timer countdownTimer;
        private int remainingTime;

        // Dispose method to clean up resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Initialize all UI components
        private void InitializeComponent()
        {
            this.labelInstruction = new System.Windows.Forms.Label();
            this.textBoxSeconds = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelCountdown = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer();
            this.SuspendLayout();

            // labelInstruction
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Location = new System.Drawing.Point(13, 13);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(124, 13);
            this.labelInstruction.TabIndex = 0;
            this.labelInstruction.Text = "Enter time in seconds:";

            // textBoxSeconds
            this.textBoxSeconds.Location = new System.Drawing.Point(16, 30);
            this.textBoxSeconds.Name = "textBoxSeconds";
            this.textBoxSeconds.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeconds.TabIndex = 1;

            // buttonStart
            this.buttonStart.Location = new System.Drawing.Point(16, 56);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start Countdown";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);

            // labelCountdown
            this.labelCountdown.AutoSize = true;
            this.labelCountdown.Location = new System.Drawing.Point(16, 86);
            this.labelCountdown.Name = "labelCountdown";
            this.labelCountdown.Size = new System.Drawing.Size(0, 13);
            this.labelCountdown.TabIndex = 3;

            // countdownTimer
            this.countdownTimer.Interval = 1000; // 1 second intervals
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.labelCountdown);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxSeconds);
            this.Controls.Add(this.labelInstruction);
            this.Name = "Form1";
            this.Text = "Countdown Timer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
