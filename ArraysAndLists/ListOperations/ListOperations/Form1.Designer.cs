namespace ListOperations
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
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			textBox1 = new TextBox();
			button4 = new Button();
			button5 = new Button();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(22, 120);
			button1.Name = "button1";
			button1.Size = new Size(143, 29);
			button1.TabIndex = 0;
			button1.Text = "Count Items";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(187, 120);
			button2.Name = "button2";
			button2.Size = new Size(165, 29);
			button2.TabIndex = 1;
			button2.Text = "Display Items";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(26, 262);
			button3.Name = "button3";
			button3.Size = new Size(139, 29);
			button3.TabIndex = 2;
			button3.Text = "Display From File";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(22, 188);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(143, 27);
			textBox1.TabIndex = 3;
			// 
			// button4
			// 
			button4.Location = new Point(189, 188);
			button4.Name = "button4";
			button4.Size = new Size(163, 29);
			button4.TabIndex = 4;
			button4.Text = "Add this name to list";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.Location = new Point(388, 186);
			button5.Name = "button5";
			button5.Size = new Size(194, 29);
			button5.TabIndex = 5;
			button5.Text = "Search for this name";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(textBox1);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Button button2;
		private Button button3;
		private TextBox textBox1;
		private Button button4;
		private Button button5;
	}
}
