namespace FlipCardApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			cardBackPictureBox = new PictureBox();
			cardFacePictureBox = new PictureBox();
			showBackButton = new Button();
			showFaceButton = new Button();
			((System.ComponentModel.ISupportInitialize)cardBackPictureBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)cardFacePictureBox).BeginInit();
			SuspendLayout();
			// 
			// cardBackPictureBox
			// 
			cardBackPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
			cardBackPictureBox.Image = (Image)resources.GetObject("cardBackPictureBox.Image");
			cardBackPictureBox.Location = new Point(231, 70);
			cardBackPictureBox.Name = "cardBackPictureBox";
			cardBackPictureBox.Size = new Size(125, 179);
			cardBackPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			cardBackPictureBox.TabIndex = 0;
			cardBackPictureBox.TabStop = false;
			// 
			// cardFacePictureBox
			// 
			cardFacePictureBox.Image = (Image)resources.GetObject("cardFacePictureBox.Image");
			cardFacePictureBox.Location = new Point(428, 70);
			cardFacePictureBox.Name = "cardFacePictureBox";
			cardFacePictureBox.Size = new Size(125, 179);
			cardFacePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			cardFacePictureBox.TabIndex = 1;
			cardFacePictureBox.TabStop = false;
			// 
			// showBackButton
			// 
			showBackButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			showBackButton.Location = new Point(231, 301);
			showBackButton.Name = "showBackButton";
			showBackButton.Size = new Size(133, 60);
			showBackButton.TabIndex = 2;
			showBackButton.Text = "Show the Card Back";
			showBackButton.UseVisualStyleBackColor = true;
			showBackButton.Click += showBackButton_Click;
			// 
			// showFaceButton
			// 
			showFaceButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			showFaceButton.Location = new Point(428, 301);
			showFaceButton.Name = "showFaceButton";
			showFaceButton.Size = new Size(125, 60);
			showFaceButton.TabIndex = 3;
			showFaceButton.Text = "Show the Card Face";
			showFaceButton.UseVisualStyleBackColor = true;
			showFaceButton.Click += showFaceButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(showFaceButton);
			Controls.Add(showBackButton);
			Controls.Add(cardFacePictureBox);
			Controls.Add(cardBackPictureBox);
			Name = "Form1";
			Text = "Flip The Card";
			((System.ComponentModel.ISupportInitialize)cardBackPictureBox).EndInit();
			((System.ComponentModel.ISupportInitialize)cardFacePictureBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox cardBackPictureBox;
		private PictureBox cardFacePictureBox;
		private Button showBackButton;
		private Button showFaceButton;
	}
}