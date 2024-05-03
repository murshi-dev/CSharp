namespace PresidentialTriviaApp
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
			questionLabel.Font = new Font("Sans Serif Collection", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
			questionLabel.Location = new Point(153, 71);
			questionLabel.Name = "questionLabel";
			questionLabel.Size = new Size(474, 115);
			questionLabel.TabIndex = 0;
			questionLabel.Text = "What former US President is known for going on an African Safari?";
			questionLabel.TextAlign = ContentAlignment.MiddleCenter;
			questionLabel.Click += questionLabel_Click;
			// 
			// answerLabel
			// 
			answerLabel.BorderStyle = BorderStyle.FixedSingle;
			answerLabel.Font = new Font("Sans Serif Collection", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point);
			answerLabel.Location = new Point(107, 226);
			answerLabel.Name = "answerLabel";
			answerLabel.Size = new Size(550, 80);
			answerLabel.TabIndex = 1;
			answerLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// showAnswerButton
			// 
			showAnswerButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
			showAnswerButton.Location = new Point(234, 350);
			showAnswerButton.Name = "showAnswerButton";
			showAnswerButton.Size = new Size(289, 47);
			showAnswerButton.TabIndex = 2;
			showAnswerButton.Text = "Show The Answer";
			showAnswerButton.UseVisualStyleBackColor = true;
			showAnswerButton.Click += showAnswerButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(showAnswerButton);
			Controls.Add(answerLabel);
			Controls.Add(questionLabel);
			Name = "Form1";
			Text = "Presidential Trivia";
			ResumeLayout(false);
		}

		#endregion

		private Label questionLabel;
		private Label answerLabel;
		private Button showAnswerButton;
	}
}