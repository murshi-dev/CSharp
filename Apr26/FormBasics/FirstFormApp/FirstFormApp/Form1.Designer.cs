namespace FirstFormApp
{
    partial class FirstFormApp
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
            b1 = new Button();
            SuspendLayout();
            // 
            // b1
            // 
            b1.Location = new Point(166, 134);
            b1.Name = "b1";
            b1.Size = new Size(265, 29);
            b1.TabIndex = 0;
            b1.Text = "Click Here For The Message";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // FirstFormApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 383);
            Controls.Add(b1);
            Name = "FirstFormApp";
            Text = "FirstFormApp";
            ResumeLayout(false);
        }

        #endregion

        private Button b1;
    }
}
