namespace SimpleCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 12);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(260, 20);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.Click += new System.EventHandler(this.NumberButton_Click);

            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.Click += new System.EventHandler(this.NumberButton_Click);

            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.Click += new System.EventHandler(this.NumberButton_Click);

            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.Click += new System.EventHandler(this.NumberButton_Click);

            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(68, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.Click += new System.EventHandler(this.NumberButton_Click);

            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(124, 106);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.Click += new System.EventHandler(this.NumberButton_Click);

            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 162);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.Click += new System.EventHandler(this.NumberButton_Click);

            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(68, 162);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.Click += new System.EventHandler(this.NumberButton_Click);

            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(124, 162);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.Click += new System.EventHandler(this.NumberButton_Click);

            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(68, 218);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(50, 50);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.Click += new System.EventHandler(this.NumberButton_Click);

            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(180, 50);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 50);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "+";
            this.buttonAdd.Click += new System.EventHandler(this.OperationButton_Click);

            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(180, 106);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(50, 50);
            this.buttonSub.TabIndex = 12;
            this.buttonSub.Text = "-";
            this.buttonSub.Click += new System.EventHandler(this.OperationButton_Click);

            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(180, 162);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(50, 50);
            this.buttonMul.TabIndex = 13;
            this.buttonMul.Text = "*";
            this.buttonMul.Click += new System.EventHandler(this.OperationButton_Click);

            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(180, 218);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(50, 50);
            this.buttonDiv.TabIndex = 14;
            this.buttonDiv.Text = "/";
            this.buttonDiv.Click += new System.EventHandler(this.OperationButton_Click);

            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(124, 218);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(50, 50);
            this.buttonEqual.TabIndex = 15;
            this.buttonEqual.Text = "=";
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);

            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 218);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(50, 50);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "C";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonClear);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
