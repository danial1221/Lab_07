using System.Windows.Forms;

namespace SquareCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonCalculate;
        private ListBox listBoxSquares;

        // Dispose method to clean up resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Method to initialize components (UI controls)
        private void InitializeComponent()
        {
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.listBoxSquares = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 12);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(260, 40);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate Squares";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);

            // 
            // listBoxSquares
            // 
            this.listBoxSquares.FormattingEnabled = true;
            this.listBoxSquares.Location = new System.Drawing.Point(12, 58);
            this.listBoxSquares.Name = "listBoxSquares";
            this.listBoxSquares.Size = new System.Drawing.Size(260, 199);
            this.listBoxSquares.TabIndex = 1;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.listBoxSquares);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "Form1";
            this.Text = "Square Calculator";
            this.ResumeLayout(false);
        }
    }
}
