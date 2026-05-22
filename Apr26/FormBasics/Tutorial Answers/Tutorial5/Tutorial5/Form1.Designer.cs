namespace Tutorial5
{
    partial class headsOrTails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(headsOrTails));
            headsPictureBox = new PictureBox();
            tailsPictureBox = new PictureBox();
            headsButton = new Button();
            tailsButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)headsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tailsPictureBox).BeginInit();
            SuspendLayout();
            // 
            // headsPictureBox
            // 
            headsPictureBox.Image = (Image)resources.GetObject("headsPictureBox.Image");
            headsPictureBox.Location = new Point(199, 85);
            headsPictureBox.Name = "headsPictureBox";
            headsPictureBox.Size = new Size(178, 158);
            headsPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            headsPictureBox.TabIndex = 0;
            headsPictureBox.TabStop = false;
            // 
            // tailsPictureBox
            // 
            tailsPictureBox.Image = (Image)resources.GetObject("tailsPictureBox.Image");
            tailsPictureBox.Location = new Point(383, 85);
            tailsPictureBox.Name = "tailsPictureBox";
            tailsPictureBox.Size = new Size(178, 158);
            tailsPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            tailsPictureBox.TabIndex = 1;
            tailsPictureBox.TabStop = false;
            // 
            // headsButton
            // 
            headsButton.Location = new Point(199, 263);
            headsButton.Name = "headsButton";
            headsButton.Size = new Size(118, 54);
            headsButton.TabIndex = 2;
            headsButton.Text = "Show Heads";
            headsButton.UseVisualStyleBackColor = true;
            headsButton.Click += headsButton_Click;
            // 
            // tailsButton
            // 
            tailsButton.Location = new Point(323, 263);
            tailsButton.Name = "tailsButton";
            tailsButton.Size = new Size(118, 54);
            tailsButton.TabIndex = 3;
            tailsButton.Text = "Show Tails";
            tailsButton.UseVisualStyleBackColor = true;
            tailsButton.Click += tailsButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(447, 263);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(118, 54);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // headsOrTails
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(tailsButton);
            Controls.Add(headsButton);
            Controls.Add(tailsPictureBox);
            Controls.Add(headsPictureBox);
            Name = "headsOrTails";
            Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)headsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tailsPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox headsPictureBox;
        private PictureBox tailsPictureBox;
        private Button headsButton;
        private Button tailsButton;
        private Button exitButton;
    }
}
