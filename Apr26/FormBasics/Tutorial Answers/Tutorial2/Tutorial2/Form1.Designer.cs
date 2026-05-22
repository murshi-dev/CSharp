namespace Tutorial2
{
    partial class clickableNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clickableNumber));
            instructionLabel = new Label();
            num1 = new PictureBox();
            num2 = new PictureBox();
            num4 = new PictureBox();
            num3 = new PictureBox();
            num5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)num1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num5).BeginInit();
            SuspendLayout();
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Location = new Point(275, 102);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(225, 17);
            instructionLabel.TabIndex = 0;
            instructionLabel.Text = "Click the image to show numbers";
            // 
            // num1
            // 
            num1.Image = (Image)resources.GetObject("num1.Image");
            num1.Location = new Point(113, 208);
            num1.Name = "num1";
            num1.Size = new Size(100, 140);
            num1.SizeMode = PictureBoxSizeMode.Zoom;
            num1.TabIndex = 1;
            num1.TabStop = false;
            num1.Click += num1_Click;
            // 
            // num2
            // 
            num2.Image = (Image)resources.GetObject("num2.Image");
            num2.Location = new Point(219, 208);
            num2.Name = "num2";
            num2.Size = new Size(100, 140);
            num2.SizeMode = PictureBoxSizeMode.Zoom;
            num2.TabIndex = 2;
            num2.TabStop = false;
            num2.Click += num2_Click;
            // 
            // num4
            // 
            num4.Image = (Image)resources.GetObject("num4.Image");
            num4.Location = new Point(431, 208);
            num4.Name = "num4";
            num4.Size = new Size(100, 140);
            num4.SizeMode = PictureBoxSizeMode.Zoom;
            num4.TabIndex = 3;
            num4.TabStop = false;
            num4.Click += num4_Click;
            // 
            // num3
            // 
            num3.Image = (Image)resources.GetObject("num3.Image");
            num3.Location = new Point(325, 208);
            num3.Name = "num3";
            num3.Size = new Size(100, 140);
            num3.SizeMode = PictureBoxSizeMode.Zoom;
            num3.TabIndex = 4;
            num3.TabStop = false;
            num3.Click += num3_Click;
            // 
            // num5
            // 
            num5.Image = (Image)resources.GetObject("num5.Image");
            num5.Location = new Point(537, 208);
            num5.Name = "num5";
            num5.Size = new Size(100, 140);
            num5.SizeMode = PictureBoxSizeMode.Zoom;
            num5.TabIndex = 5;
            num5.TabStop = false;
            num5.Click += num5_Click;
            // 
            // clickableNumber
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(num5);
            Controls.Add(num3);
            Controls.Add(num4);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(instructionLabel);
            Name = "clickableNumber";
            Text = "Clickable Number";
            ((System.ComponentModel.ISupportInitialize)num1).EndInit();
            ((System.ComponentModel.ISupportInitialize)num2).EndInit();
            ((System.ComponentModel.ISupportInitialize)num4).EndInit();
            ((System.ComponentModel.ISupportInitialize)num3).EndInit();
            ((System.ComponentModel.ISupportInitialize)num5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label instructionLabel;
        private PictureBox num1;
        private PictureBox num2;
        private PictureBox num4;
        private PictureBox num3;
        private PictureBox num5;
    }
}
