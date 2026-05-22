namespace TextBoxDemo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void readInputButton_Click(object sender, EventArgs e)
		{
			string fullName;
			fullName=fnameTextBox.Text+" "+lnameTextBox.Text;
			outputLabel.Text = fullName;
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			fnameTextBox.Text = "";
			lnameTextBox.Text = "";
			outputLabel.Text = "";
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}