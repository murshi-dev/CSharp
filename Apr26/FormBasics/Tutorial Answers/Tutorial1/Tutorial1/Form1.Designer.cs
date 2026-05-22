namespace Tutorial1
{
    partial class latinTranslator
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
            latin = new Label();
            englishTranslate = new Label();
            sinsterButton = new Button();
            dexterButton = new Button();
            mediumButton = new Button();
            englishTranslateAnswer = new Label();
            SuspendLayout();
            // 
            // latin
            // 
            latin.AutoSize = true;
            latin.Location = new Point(363, 91);
            latin.Name = "latin";
            latin.Size = new Size(39, 17);
            latin.TabIndex = 0;
            latin.Text = "Latin";
            // 
            // englishTranslate
            // 
            englishTranslate.AutoSize = true;
            englishTranslate.Location = new Point(327, 225);
            englishTranslate.Name = "englishTranslate";
            englishTranslate.Size = new Size(120, 17);
            englishTranslate.TabIndex = 1;
            englishTranslate.Text = "English Translate";
            // 
            // sinsterButton
            // 
            sinsterButton.Location = new Point(195, 136);
            sinsterButton.Name = "sinsterButton";
            sinsterButton.Size = new Size(94, 29);
            sinsterButton.TabIndex = 2;
            sinsterButton.Text = "sinister";
            sinsterButton.UseVisualStyleBackColor = true;
            sinsterButton.Click += sinsterButton_Click;
            // 
            // dexterButton
            // 
            dexterButton.Location = new Point(338, 136);
            dexterButton.Name = "dexterButton";
            dexterButton.Size = new Size(94, 29);
            dexterButton.TabIndex = 3;
            dexterButton.Text = "dexter";
            dexterButton.UseVisualStyleBackColor = true;
            dexterButton.Click += dexterButton_Click;
            // 
            // mediumButton
            // 
            mediumButton.Location = new Point(476, 136);
            mediumButton.Name = "mediumButton";
            mediumButton.Size = new Size(94, 29);
            mediumButton.TabIndex = 4;
            mediumButton.Text = "medium";
            mediumButton.UseVisualStyleBackColor = true;
            mediumButton.Click += mediumButton_Click;
            // 
            // englishTranslateAnswer
            // 
            englishTranslateAnswer.BorderStyle = BorderStyle.FixedSingle;
            englishTranslateAnswer.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            englishTranslateAnswer.Location = new Point(246, 272);
            englishTranslateAnswer.Name = "englishTranslateAnswer";
            englishTranslateAnswer.Size = new Size(282, 32);
            englishTranslateAnswer.TabIndex = 5;
            englishTranslateAnswer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // latinTranslator
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(englishTranslateAnswer);
            Controls.Add(mediumButton);
            Controls.Add(dexterButton);
            Controls.Add(sinsterButton);
            Controls.Add(englishTranslate);
            Controls.Add(latin);
            Name = "latinTranslator";
            Text = "Latin Translator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label latin;
        private Label englishTranslate;
        private Button sinsterButton;
        private Button dexterButton;
        private Button mediumButton;
        private Label englishTranslateAnswer;
    }
}
