namespace LanguageTranslatorApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void italianButton_Click(object sender, EventArgs e)
		{
			translationLabel.Text = "Boungiorno";
		}

		private void spanishButton_Click(object sender, EventArgs e)
		{
			translationLabel.Text = "Buenos Dias";
		}

		private void germanButton_Click(object sender, EventArgs e)
		{
			translationLabel.Text = "Guten Morgan";
		}
	}
}