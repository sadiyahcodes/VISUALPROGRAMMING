using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace PhotoViewerApp
{
    public class PhotoViewerForm : Form
    {
        private PictureBox pictureBox;
        private TextBox txtLocation;
        private Button btnSetLocation;
        private Button btnNext;
        private Button btnPrevious;
        private Label lblTotalPhotos;
        private FolderBrowserDialog folderBrowserDialog;

        private string[] imageFiles;
        private int currentIndex = 0;

        public PhotoViewerForm()
        {
            // Initialize components
            pictureBox = new PictureBox();
            txtLocation = new TextBox();
            btnSetLocation = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            lblTotalPhotos = new Label();
            folderBrowserDialog = new FolderBrowserDialog();

            // Form settings
            this.Text = "Photo Viewer";
            this.Size = new System.Drawing.Size(600, 500);

            // PictureBox settings
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Dock = DockStyle.Top;
            pictureBox.Height = 300;
            this.Controls.Add(pictureBox);

            // Location TextBox
            txtLocation.Location = new System.Drawing.Point(20, 320);
            txtLocation.Width = 400;
            this.Controls.Add(txtLocation);

            // Set Location Button
            btnSetLocation.Text = "Set";
            btnSetLocation.Location = new System.Drawing.Point(430, 320);
            btnSetLocation.Click += new EventHandler(BtnSetLocation_Click);
            this.Controls.Add(btnSetLocation);

            // Total Photos Label
            lblTotalPhotos.Text = "Total Photos: 0";
            lblTotalPhotos.Location = new System.Drawing.Point(20, 350);
            this.Controls.Add(lblTotalPhotos);

            // Previous Button
            btnPrevious.Text = "Previous";
            btnPrevious.Location = new System.Drawing.Point(20, 380);
            btnPrevious.Click += new EventHandler(BtnPrevious_Click);
            btnPrevious.Enabled = false;
            this.Controls.Add(btnPrevious);

            // Next Button
            btnNext.Text = "Next";
            btnNext.Location = new System.Drawing.Point(100, 380);
            btnNext.Click += new EventHandler(BtnNext_Click);
            btnNext.Enabled = false;
            this.Controls.Add(btnNext);
        }

        private void BtnSetLocation_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtLocation.Text = folderBrowserDialog.SelectedPath;
                LoadImages(txtLocation.Text);
            }
        }

        private void LoadImages(string folderPath)
        {
            // Get all image files in the folder
            imageFiles = Directory.GetFiles(folderPath, "*.jpg");
            imageFiles = imageFiles.Concat(Directory.GetFiles(folderPath, "*.png")).ToArray();
            imageFiles = imageFiles.Concat(Directory.GetFiles(folderPath, "*.jpeg")).ToArray();

            if (imageFiles.Length > 0)
            {
                currentIndex = 0;
                DisplayImage();
                lblTotalPhotos.Text = $"Total Photos: {imageFiles.Length}";
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
            }
            else
            {
                MessageBox.Show("No images found in the selected folder.", "No Images", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblTotalPhotos.Text = "Total Photos: 0";
                pictureBox.Image = null;
                btnNext.Enabled = false;
                btnPrevious.Enabled = false;
            }
        }

        private void DisplayImage()
        {
            if (imageFiles.Length > 0 && currentIndex >= 0 && currentIndex < imageFiles.Length)
            {
                pictureBox.Image = Image.FromFile(imageFiles[currentIndex]);
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (imageFiles.Length > 0 && currentIndex < imageFiles.Length - 1)
            {
                currentIndex++;
                DisplayImage();
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (imageFiles.Length > 0 && currentIndex > 0)
            {
                currentIndex--;
                DisplayImage();
            }
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PhotoViewerForm());
        }
    }
}
