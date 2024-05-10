namespace CalculatorTextWithParse
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
			n1TextBox = new TextBox();
			n2TextBox = new TextBox();
			addButton = new Button();
			button2 = new Button();
			label3 = new Label();
			resultLabel = new Label();
			multiplyButton = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(148, 92);
			label1.Name = "label1";
			label1.Size = new Size(75, 20);
			label1.TabIndex = 0;
			label1.Text = "Number 1";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(148, 162);
			label2.Name = "label2";
			label2.Size = new Size(75, 20);
			label2.TabIndex = 1;
			label2.Text = "Number 2";
			// 
			// n1TextBox
			// 
			n1TextBox.Location = new Point(246, 85);
			n1TextBox.Name = "n1TextBox";
			n1TextBox.Size = new Size(125, 27);
			n1TextBox.TabIndex = 2;
			// 
			// n2TextBox
			// 
			n2TextBox.Location = new Point(246, 159);
			n2TextBox.Name = "n2TextBox";
			n2TextBox.Size = new Size(125, 27);
			n2TextBox.TabIndex = 3;
			// 
			// addButton
			// 
			addButton.Location = new Point(148, 293);
			addButton.Name = "addButton";
			addButton.Size = new Size(94, 29);
			addButton.TabIndex = 4;
			addButton.Text = "Add";
			addButton.UseVisualStyleBackColor = true;
			addButton.Click += addButton_Click;
			// 
			// button2
			// 
			button2.Location = new Point(148, 358);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 5;
			button2.Text = "Clear";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(154, 226);
			label3.Name = "label3";
			label3.Size = new Size(49, 20);
			label3.TabIndex = 6;
			label3.Text = "Result";
			// 
			// resultLabel
			// 
			resultLabel.BorderStyle = BorderStyle.FixedSingle;
			resultLabel.Location = new Point(246, 225);
			resultLabel.Name = "resultLabel";
			resultLabel.Size = new Size(125, 30);
			resultLabel.TabIndex = 7;
			// 
			// multiplyButton
			// 
			multiplyButton.Location = new Point(277, 293);
			multiplyButton.Name = "multiplyButton";
			multiplyButton.Size = new Size(94, 29);
			multiplyButton.TabIndex = 8;
			multiplyButton.Text = "Multiply";
			multiplyButton.UseVisualStyleBackColor = true;
			multiplyButton.Click += multiplyButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(multiplyButton);
			Controls.Add(resultLabel);
			Controls.Add(label3);
			Controls.Add(button2);
			Controls.Add(addButton);
			Controls.Add(n2TextBox);
			Controls.Add(n1TextBox);
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
		private TextBox n1TextBox;
		private TextBox n2TextBox;
		private Button addButton;
		private Button button2;
		private Label label3;
		private Label resultLabel;
		private Button multiplyButton;
	}
}