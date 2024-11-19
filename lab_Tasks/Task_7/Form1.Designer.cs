using System;
using System.Windows.Forms;  // Required for Windows Forms controls like Label, Timer

namespace WallClockApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTime;
        private Timer timerClock;

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
            this.labelTime = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer();
            this.SuspendLayout();

            // labelTime
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(12, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(230, 37);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:00:00 AM";

            // timerClock
            this.timerClock.Interval = 1000;  // 1 second interval
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 61);
            this.Controls.Add(this.labelTime);
            this.Name = "Form1";
            this.Text = "Wall Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
