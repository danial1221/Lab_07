using System;
using System.Windows.Forms;
namespace FactorialCalculatorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelInstruction;
        private TextBox textBoxInput;
        private Button buttonCalculate;
        private Label labelResult;

        // Dispose method
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Initialize all components
        private void InitializeComponent()
        {
            this.labelInstruction = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // labelInstruction
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Location = new System.Drawing.Point(13, 13);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(103, 13);
            this.labelInstruction.TabIndex = 0;
            this.labelInstruction.Text = "Enter a number:";

            // textBoxInput
            this.textBoxInput.Location = new System.Drawing.Point(16, 30);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput.TabIndex = 1;

            // buttonCalculate
            this.buttonCalculate.Location = new System.Drawing.Point(16, 56);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 23);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Calculate Factorial";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);

            // labelResult
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(16, 86);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 3;

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelInstruction);
            this.Name = "Form1";
            this.Text = "Factorial Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
