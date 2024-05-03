namespace LanguageTranslatorApp
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
			instructionLabel = new Label();
			translationLabel = new Label();
			italianButton = new Button();
			spanishButton = new Button();
			germanButton = new Button();
			SuspendLayout();
			// 
			// instructionLabel
			// 
			instructionLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			instructionLabel.Location = new Point(184, 58);
			instructionLabel.Name = "instructionLabel";
			instructionLabel.Size = new Size(431, 35);
			instructionLabel.TabIndex = 0;
			instructionLabel.Text = "Select a language and I will say Good Morning";
			// 
			// translationLabel
			// 
			translationLabel.BorderStyle = BorderStyle.FixedSingle;
			translationLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			translationLabel.Location = new Point(184, 117);
			translationLabel.Name = "translationLabel";
			translationLabel.Size = new Size(381, 46);
			translationLabel.TabIndex = 1;
			translationLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// italianButton
			// 
			italianButton.Location = new Point(184, 209);
			italianButton.Name = "italianButton";
			italianButton.Size = new Size(94, 29);
			italianButton.TabIndex = 2;
			italianButton.Text = "Italian";
			italianButton.UseVisualStyleBackColor = true;
			italianButton.Click += italianButton_Click;
			// 
			// spanishButton
			// 
			spanishButton.Location = new Point(326, 209);
			spanishButton.Name = "spanishButton";
			spanishButton.Size = new Size(94, 29);
			spanishButton.TabIndex = 3;
			spanishButton.Text = "Spanish";
			spanishButton.UseVisualStyleBackColor = true;
			spanishButton.Click += spanishButton_Click;
			// 
			// germanButton
			// 
			germanButton.Location = new Point(471, 209);
			germanButton.Name = "germanButton";
			germanButton.Size = new Size(94, 29);
			germanButton.TabIndex = 4;
			germanButton.Text = "German";
			germanButton.UseVisualStyleBackColor = true;
			germanButton.Click += germanButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(germanButton);
			Controls.Add(spanishButton);
			Controls.Add(italianButton);
			Controls.Add(translationLabel);
			Controls.Add(instructionLabel);
			Name = "Form1";
			Text = "Language Translator";
			ResumeLayout(false);
		}

		#endregion

		private Label instructionLabel;
		private Label translationLabel;
		private Button italianButton;
		private Button spanishButton;
		private Button germanButton;
	}
}