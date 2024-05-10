namespace TextBoxDemo
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
			label1 = new Label();
			label2 = new Label();
			fnameTextBox = new TextBox();
			outputLabel = new Label();
			readInputButton = new Button();
			exitButton = new Button();
			clearButton = new Button();
			label3 = new Label();
			lnameTextBox = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(192, 61);
			label1.Name = "label1";
			label1.Size = new Size(154, 20);
			label1.TabIndex = 0;
			label1.Text = "Enter Your First Name:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(192, 198);
			label2.Name = "label2";
			label2.Size = new Size(112, 20);
			label2.TabIndex = 1;
			label2.Text = "Your Full Name:";
			// 
			// fnameTextBox
			// 
			fnameTextBox.Location = new Point(364, 58);
			fnameTextBox.Name = "fnameTextBox";
			fnameTextBox.Size = new Size(163, 27);
			fnameTextBox.TabIndex = 2;
			// 
			// outputLabel
			// 
			outputLabel.BorderStyle = BorderStyle.FixedSingle;
			outputLabel.Location = new Point(364, 198);
			outputLabel.Name = "outputLabel";
			outputLabel.Size = new Size(163, 20);
			outputLabel.TabIndex = 3;
			// 
			// readInputButton
			// 
			readInputButton.Location = new Point(192, 260);
			readInputButton.Name = "readInputButton";
			readInputButton.Size = new Size(150, 40);
			readInputButton.TabIndex = 4;
			readInputButton.Text = "Show Full name";
			readInputButton.UseVisualStyleBackColor = true;
			readInputButton.Click += readInputButton_Click;
			// 
			// exitButton
			// 
			exitButton.Location = new Point(310, 320);
			exitButton.Name = "exitButton";
			exitButton.Size = new Size(94, 38);
			exitButton.TabIndex = 5;
			exitButton.Text = "Exit";
			exitButton.UseVisualStyleBackColor = true;
			exitButton.Click += exitButton_Click;
			// 
			// clearButton
			// 
			clearButton.Location = new Point(383, 260);
			clearButton.Name = "clearButton";
			clearButton.Size = new Size(125, 40);
			clearButton.TabIndex = 6;
			clearButton.Text = "Clear";
			clearButton.UseVisualStyleBackColor = true;
			clearButton.Click += clearButton_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(192, 134);
			label3.Name = "label3";
			label3.Size = new Size(153, 20);
			label3.TabIndex = 7;
			label3.Text = "Enter Your Last Name:";
			// 
			// lnameTextBox
			// 
			lnameTextBox.Location = new Point(364, 127);
			lnameTextBox.Name = "lnameTextBox";
			lnameTextBox.Size = new Size(163, 27);
			lnameTextBox.TabIndex = 8;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lnameTextBox);
			Controls.Add(label3);
			Controls.Add(clearButton);
			Controls.Add(exitButton);
			Controls.Add(readInputButton);
			Controls.Add(outputLabel);
			Controls.Add(fnameTextBox);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox fnameTextBox;
		private Label outputLabel;
		private Button readInputButton;
		private Button exitButton;
		private Button clearButton;
		private Label label3;
		private TextBox lnameTextBox;
	}
}