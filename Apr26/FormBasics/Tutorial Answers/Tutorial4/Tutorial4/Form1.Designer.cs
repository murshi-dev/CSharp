namespace Tutorial4
{
    partial class jokeAndPunchLine
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
            setupButton = new Button();
            punchLineButton = new Button();
            labelControl = new Label();
            SuspendLayout();
            // 
            // setupButton
            // 
            setupButton.Location = new Point(158, 118);
            setupButton.Name = "setupButton";
            setupButton.Size = new Size(117, 65);
            setupButton.TabIndex = 0;
            setupButton.Text = "Setup";
            setupButton.UseVisualStyleBackColor = true;
            setupButton.Click += setupButton_Click;
            // 
            // punchLineButton
            // 
            punchLineButton.Location = new Point(400, 118);
            punchLineButton.Name = "punchLineButton";
            punchLineButton.Size = new Size(117, 65);
            punchLineButton.TabIndex = 1;
            punchLineButton.Text = "Punch Line";
            punchLineButton.UseVisualStyleBackColor = true;
            punchLineButton.Click += punchLineButton_Click;
            // 
            // labelControl
            // 
            labelControl.BorderStyle = BorderStyle.FixedSingle;
            labelControl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl.Location = new Point(158, 261);
            labelControl.Name = "labelControl";
            labelControl.Size = new Size(359, 81);
            labelControl.TabIndex = 2;
            labelControl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // jokeAndPunchLine
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 450);
            Controls.Add(labelControl);
            Controls.Add(punchLineButton);
            Controls.Add(setupButton);
            Name = "jokeAndPunchLine";
            Text = "Joke and Punch Line";
            ResumeLayout(false);
        }

        #endregion

        private Button setupButton;
        private Button punchLineButton;
        private Label labelControl;
    }
}
