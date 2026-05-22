namespace Tutorial3
{
    partial class cardIdentifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cardIdentifier));
            instructionLabel = new Label();
            spade2 = new PictureBox();
            heart7 = new PictureBox();
            clubs10 = new PictureBox();
            kingSpade = new PictureBox();
            aceSpade = new PictureBox();
            answerBox = new Label();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)spade2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heart7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clubs10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kingSpade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aceSpade).BeginInit();
            SuspendLayout();
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Location = new Point(285, 58);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(194, 17);
            instructionLabel.TabIndex = 0;
            instructionLabel.Text = "Click a Card to see its Name";
            // 
            // spade2
            // 
            spade2.Image = (Image)resources.GetObject("spade2.Image");
            spade2.Location = new Point(117, 114);
            spade2.Name = "spade2";
            spade2.Size = new Size(100, 140);
            spade2.SizeMode = PictureBoxSizeMode.Zoom;
            spade2.TabIndex = 1;
            spade2.TabStop = false;
            spade2.Click += spade2_Click;
            // 
            // heart7
            // 
            heart7.Image = (Image)resources.GetObject("heart7.Image");
            heart7.Location = new Point(223, 114);
            heart7.Name = "heart7";
            heart7.Size = new Size(100, 140);
            heart7.SizeMode = PictureBoxSizeMode.Zoom;
            heart7.TabIndex = 2;
            heart7.TabStop = false;
            heart7.Click += heart7_Click;
            // 
            // clubs10
            // 
            clubs10.Image = (Image)resources.GetObject("clubs10.Image");
            clubs10.Location = new Point(329, 114);
            clubs10.Name = "clubs10";
            clubs10.Size = new Size(100, 140);
            clubs10.SizeMode = PictureBoxSizeMode.Zoom;
            clubs10.TabIndex = 3;
            clubs10.TabStop = false;
            clubs10.Click += clubs10_Click;
            // 
            // kingSpade
            // 
            kingSpade.Image = (Image)resources.GetObject("kingSpade.Image");
            kingSpade.Location = new Point(435, 114);
            kingSpade.Name = "kingSpade";
            kingSpade.Size = new Size(100, 140);
            kingSpade.SizeMode = PictureBoxSizeMode.Zoom;
            kingSpade.TabIndex = 4;
            kingSpade.TabStop = false;
            kingSpade.Click += kingSpade_Click;
            // 
            // aceSpade
            // 
            aceSpade.Image = (Image)resources.GetObject("aceSpade.Image");
            aceSpade.Location = new Point(541, 114);
            aceSpade.Name = "aceSpade";
            aceSpade.Size = new Size(100, 140);
            aceSpade.SizeMode = PictureBoxSizeMode.Zoom;
            aceSpade.TabIndex = 5;
            aceSpade.TabStop = false;
            aceSpade.Click += aceSpade_Click;
            // 
            // answerBox
            // 
            answerBox.BorderStyle = BorderStyle.FixedSingle;
            answerBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            answerBox.Location = new Point(117, 281);
            answerBox.Name = "answerBox";
            answerBox.Size = new Size(524, 57);
            answerBox.TabIndex = 6;
            answerBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(329, 361);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(100, 40);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += button1_Click;
            // 
            // cardIdentifier
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(answerBox);
            Controls.Add(aceSpade);
            Controls.Add(kingSpade);
            Controls.Add(clubs10);
            Controls.Add(heart7);
            Controls.Add(spade2);
            Controls.Add(instructionLabel);
            Name = "cardIdentifier";
            Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)spade2).EndInit();
            ((System.ComponentModel.ISupportInitialize)heart7).EndInit();
            ((System.ComponentModel.ISupportInitialize)clubs10).EndInit();
            ((System.ComponentModel.ISupportInitialize)kingSpade).EndInit();
            ((System.ComponentModel.ISupportInitialize)aceSpade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label instructionLabel;
        private PictureBox spade2;
        private PictureBox heart7;
        private PictureBox clubs10;
        private PictureBox kingSpade;
        private PictureBox aceSpade;
        private Label answerBox;
        private Button exitButton;
    }
}
