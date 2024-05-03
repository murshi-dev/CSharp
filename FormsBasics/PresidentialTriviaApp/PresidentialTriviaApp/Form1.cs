namespace PresidentialTriviaApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void questionLabel_Click(object sender, EventArgs e)
		{

		}

		//click answer button displays the label with the provided answer
		private void showAnswerButton_Click(object sender, EventArgs e)
		{
			answerLabel.Text = "Theodore Roosevelt";
		}
	}
}