namespace FlagsAndCountriesApp
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
			instructionLabel = new Label();
			finlandPictureBox = new PictureBox();
			germanyPictureBox = new PictureBox();
			francePictureBox = new PictureBox();
			countryLabel = new Label();
			((System.ComponentModel.ISupportInitialize)finlandPictureBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)germanyPictureBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)francePictureBox).BeginInit();
			SuspendLayout();
			// 
			// instructionLabel
			// 
			instructionLabel.AutoSize = true;
			instructionLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			instructionLabel.Location = new Point(183, 51);
			instructionLabel.Name = "instructionLabel";
			instructionLabel.Size = new Size(414, 28);
			instructionLabel.TabIndex = 0;
			instructionLabel.Text = "Select a flag to see the name of the country";
			// 
			// finlandPictureBox
			// 
			finlandPictureBox.Image = (Image)resources.GetObject("finlandPictureBox.Image");
			finlandPictureBox.Location = new Point(147, 143);
			finlandPictureBox.Name = "finlandPictureBox";
			finlandPictureBox.Size = new Size(125, 62);
			finlandPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
			finlandPictureBox.TabIndex = 1;
			finlandPictureBox.TabStop = false;
			finlandPictureBox.Click += finlandPictureBox_Click;
			// 
			// germanyPictureBox
			// 
			germanyPictureBox.Image = (Image)resources.GetObject("germanyPictureBox.Image");
			germanyPictureBox.Location = new Point(333, 143);
			germanyPictureBox.Name = "germanyPictureBox";
			germanyPictureBox.Size = new Size(125, 62);
			germanyPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
			germanyPictureBox.TabIndex = 2;
			germanyPictureBox.TabStop = false;
			germanyPictureBox.Click += germanyPictureBox_Click;
			// 
			// francePictureBox
			// 
			francePictureBox.Image = (Image)resources.GetObject("francePictureBox.Image");
			francePictureBox.Location = new Point(531, 143);
			francePictureBox.Name = "francePictureBox";
			francePictureBox.Size = new Size(125, 62);
			francePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
			francePictureBox.TabIndex = 3;
			francePictureBox.TabStop = false;
			francePictureBox.Click += francePictureBox_Click;
			// 
			// countryLabel
			// 
			countryLabel.BorderStyle = BorderStyle.FixedSingle;
			countryLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			countryLabel.Location = new Point(232, 276);
			countryLabel.Name = "countryLabel";
			countryLabel.Size = new Size(318, 61);
			countryLabel.TabIndex = 4;
			countryLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(countryLabel);
			Controls.Add(francePictureBox);
			Controls.Add(germanyPictureBox);
			Controls.Add(finlandPictureBox);
			Controls.Add(instructionLabel);
			Name = "Form1";
			Text = "Flags And Countries App";
			((System.ComponentModel.ISupportInitialize)finlandPictureBox).EndInit();
			((System.ComponentModel.ISupportInitialize)germanyPictureBox).EndInit();
			((System.ComponentModel.ISupportInitialize)francePictureBox).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label instructionLabel;
		private PictureBox finlandPictureBox;
		private PictureBox germanyPictureBox;
		private PictureBox francePictureBox;
		private Label countryLabel;
	}
}