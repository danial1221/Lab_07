using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PhotoViewerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Handle the Browse button click event to select a folder
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            // Show Folder Browser Dialog
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;

                // Clear the existing images
                flowLayoutPanelImages.Controls.Clear();

                // Load and display images from the selected folder
                LoadImagesFromFolder(folderPath);
            }
        }

        // Load images from the selected folder and display them as thumbnails
        private void LoadImagesFromFolder(string folderPath)
        {
            // Get all image files in the folder (e.g., jpg, png, bmp)
            string[] imageFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.TopDirectoryOnly);
            foreach (var file in imageFiles)
            {
                // Check if the file is an image (jpg, png, bmp)
                if (file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                    file.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                    file.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
                {
                    // Create a new PictureBox for each image
                    PictureBox pictureBoxThumbnail = new PictureBox();
                    pictureBoxThumbnail.Image = new Bitmap(file);
                    pictureBoxThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxThumbnail.Width = 100;  // Thumbnail width
                    pictureBoxThumbnail.Height = 100; // Thumbnail height
                    pictureBoxThumbnail.Tag = file;   // Store the file path as the Tag

                    // Add an event handler to display the larger image when clicked
                    pictureBoxThumbnail.Click += PictureBoxThumbnail_Click;

                    // Add the thumbnail to the FlowLayoutPanel
                    flowLayoutPanelImages.Controls.Add(pictureBoxThumbnail);
                }
            }
        }

        // Handle the click event on a thumbnail to display the full-size image in the PictureBox
        private void PictureBoxThumbnail_Click(object sender, EventArgs e)
        {
            // Get the file path stored in the Tag of the clicked PictureBox
            string imagePath = (sender as PictureBox).Tag.ToString();

            // Load the image and display it in the PictureBox
            pictureBoxPreview.Image = new Bitmap(imagePath);
        }
    }
}
