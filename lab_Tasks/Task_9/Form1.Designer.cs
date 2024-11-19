using System;
using System.Windows.Forms;

namespace TextBoxLimitApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxInput;
        private Label labelCharacterCount;
        private Button buttonSubmit;

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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelCharacterCount = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // textBoxInput
            this.textBoxInput.Location = new System.Drawing.Point(12, 12);
            this.textBoxInput.MaxLength = 160;  // Set the max length of text in the TextBox
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(260, 50);
            this.textBoxInput.TabIndex = 0;

            // labelCharacterCount
            this.labelCharacterCount.AutoSize = true;
            this.labelCharacterCount.Location = new System.Drawing.Point(12, 65);
            this.labelCharacterCount.Name = "labelCharacterCount";
            this.labelCharacterCount.Size = new System.Drawing.Size(116, 13);
            this.labelCharacterCount.TabIndex = 1;
            this.labelCharacterCount.Text = "Characters: 0/160";

            // buttonSubmit
            this.buttonSubmit.Location = new System.Drawing.Point(12, 85);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelCharacterCount);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "TextBox Character Limit";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
