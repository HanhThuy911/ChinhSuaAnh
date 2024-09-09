namespace ProductA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnCrop = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.liveCameraBox = new System.Windows.Forms.PictureBox();
            this.btnStartCamera = new System.Windows.Forms.Button();
            this.btnStopCamera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liveCameraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapture
            // 
            this.btnCapture.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCapture.AutoSize = true;
            this.btnCapture.Location = new System.Drawing.Point(424, 814);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(87, 57);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnCrop
            // 
            this.btnCrop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCrop.AutoSize = true;
            this.btnCrop.Location = new System.Drawing.Point(592, 814);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(87, 57);
            this.btnCrop.TabIndex = 2;
            this.btnCrop.Text = "Crop";
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRotate.AutoSize = true;
            this.btnRotate.Location = new System.Drawing.Point(738, 814);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(87, 57);
            this.btnRotate.TabIndex = 3;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // liveCameraBox
            // 
            this.liveCameraBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.liveCameraBox.BackColor = System.Drawing.Color.RosyBrown;
            this.liveCameraBox.Location = new System.Drawing.Point(25, 23);
            this.liveCameraBox.Name = "liveCameraBox";
            this.liveCameraBox.Size = new System.Drawing.Size(817, 740);
            this.liveCameraBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.liveCameraBox.TabIndex = 4;
            this.liveCameraBox.TabStop = false;
            this.liveCameraBox.Click += new System.EventHandler(this.liveCameraBox_Click);
            // 
            // btnStartCamera
            // 
            this.btnStartCamera.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStartCamera.AutoSize = true;
            this.btnStartCamera.Location = new System.Drawing.Point(41, 814);
            this.btnStartCamera.Name = "btnStartCamera";
            this.btnStartCamera.Size = new System.Drawing.Size(126, 57);
            this.btnStartCamera.TabIndex = 5;
            this.btnStartCamera.Text = "Start";
            this.btnStartCamera.UseVisualStyleBackColor = true;
            this.btnStartCamera.Click += new System.EventHandler(this.btnStartCamera_Click);
            // 
            // btnStopCamera
            // 
            this.btnStopCamera.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStopCamera.AutoSize = true;
            this.btnStopCamera.Location = new System.Drawing.Point(212, 814);
            this.btnStopCamera.Name = "btnStopCamera";
            this.btnStopCamera.Size = new System.Drawing.Size(126, 57);
            this.btnStopCamera.TabIndex = 6;
            this.btnStopCamera.Text = "Stop";
            this.btnStopCamera.UseVisualStyleBackColor = true;
            this.btnStopCamera.Click += new System.EventHandler(this.btnStopCamera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(872, 906);
            this.Controls.Add(this.btnStopCamera);
            this.Controls.Add(this.btnStartCamera);
            this.Controls.Add(this.liveCameraBox);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.btnCrop);
            this.Controls.Add(this.btnCapture);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Design picture";
            ((System.ComponentModel.ISupportInitialize)(this.liveCameraBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.PictureBox liveCameraBox;
        private System.Windows.Forms.Button btnStartCamera;
        private System.Windows.Forms.Button btnStopCamera;
    }
}

