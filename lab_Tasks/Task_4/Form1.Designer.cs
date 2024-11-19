using System.Windows.Forms;

namespace FahrenheitToCelsiusConverter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Declare controls here (make sure the names match what you are using in Form1.cs)
        private Label labelFahrenheit;
        private TextBox textBoxFahrenheit;
        private Button buttonConvert;
        private Label labelResult;

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
            this.labelFahrenheit = new System.Windows.Forms.Label();
            this.textBoxFahrenheit = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // labelFahrenheit
            // 
            this.labelFahrenheit.AutoSize = true;
            this.labelFahrenheit.Location = new System.Drawing.Point(12, 9);
            this.labelFahrenheit.Name = "labelFahrenheit";
            this.labelFahrenheit.Size = new System.Drawing.Size(101, 13);
            this.labelFahrenheit.TabIndex = 0;
            this.labelFahrenheit.Text = "Enter Fahrenheit:";

            // 
            // textBoxFahrenheit
            // 
            this.textBoxFahrenheit.Location = new System.Drawing.Point(15, 25);
            this.textBoxFahrenheit.Name = "textBoxFahrenheit";
            this.textBoxFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.textBoxFahrenheit.TabIndex = 1;

            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(15, 51);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(100, 23);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);

            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 90);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(46, 13);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Celsius: ";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxFahrenheit);
            this.Controls.Add(this.labelFahrenheit);
            this.Name = "Form1";
            this.Text = "Fahrenheit to Celsius Converter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
