namespace PresidentTrivia
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
            questionLabel = new Label();
            answerLabel = new Label();
            showAnswerButton = new Button();
            SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            questionLabel.Location = new Point(58, 49);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(493, 72);
            questionLabel.TabIndex = 0;
            questionLabel.Text = "What Former US President is known for going on an African Safari?";
            questionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answerLabel
            // 
            answerLabel.BorderStyle = BorderStyle.FixedSingle;
            answerLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answerLabel.Location = new Point(73, 139);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(478, 43);
            answerLabel.TabIndex = 1;
            answerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // showAnswerButton
            // 
            showAnswerButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showAnswerButton.Location = new Point(198, 212);
            showAnswerButton.Name = "showAnswerButton";
            showAnswerButton.Size = new Size(214, 46);
            showAnswerButton.TabIndex = 2;
            showAnswerButton.Text = "Show The Answer";
            showAnswerButton.UseVisualStyleBackColor = true;
            showAnswerButton.Click += showAnswerButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 301);
            Controls.Add(showAnswerButton);
            Controls.Add(answerLabel);
            Controls.Add(questionLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label questionLabel;
        private Label answerLabel;
        private Button showAnswerButton;
    }
}
