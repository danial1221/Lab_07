using System;
using System.Windows.Forms;

namespace PhotoViewerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonBrowse;
        private FlowLayoutPanel flowLayoutPanelImages;
        private PictureBox pictureBoxPreview;
        private FolderBrowserDialog folderBrowserDialog;

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
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.flowLayoutPanelImages = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();

            // buttonBrowse
            this.buttonBrowse.Location = new System.Drawing.Point(12, 12);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);

            // flowLayoutPanelImages
            this.flowLayoutPanelImages.AutoScroll = true;
            this.flowLayoutPanelImages.Location = new System.Drawing.Point(12, 41);
            this.flowLayoutPanelImages.Name = "flowLayoutPanelImages";
            this.flowLayoutPanelImages.Size = new System.Drawing.Size(200, 300);
            this.flowLayoutPanelImages.TabIndex = 1;

            // pictureBoxPreview
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Location = new System.Drawing.Point(220, 41);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(400, 300);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 2;
            this.pictureBoxPreview.TabStop = false;

            // Form1
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.flowLayoutPanelImages);
            this.Controls.Add(this.buttonBrowse);
            this.Name = "Form1";
            this.Text = "Photo Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
