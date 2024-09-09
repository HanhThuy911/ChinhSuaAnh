using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ProductA
{
    public partial class Form1 : Form
    {
        private Bitmap capturedImage;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                capturedImage = new Bitmap(openFileDialog.FileName);
                liveCameraBox.Image = capturedImage;
            }
        }

        private void btnCrop_Click(object sender, EventArgs e)
        {
            if (capturedImage != null)
            {
                // Cắt ảnh từ vị trí (100, 100) và kích thước 200x200
                Rectangle cropRect = new Rectangle(100, 100, 200, 200);
                if (cropRect.X + cropRect.Width <= capturedImage.Width && cropRect.Y + cropRect.Height <= capturedImage.Height)
                {
                    Bitmap croppedImage = capturedImage.Clone(cropRect, capturedImage.PixelFormat);
                    capturedImage = croppedImage;
                    liveCameraBox.Image = capturedImage; // Display the cropped image in liveCameraBox
                }
                else
                {
                    MessageBox.Show("Crop rectangle is out of bounds.");
                }
            }
            else
            {
                MessageBox.Show("No image available to crop.");
            }
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (capturedImage != null)
            {
                // Xoay ảnh 90 độ
                capturedImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                liveCameraBox.Image = capturedImage; // Display the rotated image in liveCameraBox
            }
            else
            {
                MessageBox.Show("No image available to rotate.");
            }
        }

        private void btnStartCamera_Click(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count > 0)
            {
                // Sử dụng thiết bị camera đầu tiên
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
                videoSource.Start();
            }
            else
            {
                MessageBox.Show("No camera devices found.");
            }
        }

        private void btnStopCamera_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            liveCameraBox.Image = frame;
            capturedImage = frame;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            base.OnFormClosing(e);
        }

        private void liveCameraBox_Click(object sender, EventArgs e)
        {

        }
    }
}
