namespace FlipCardApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			cardBackPictureBox.Visible = false;
			cardFacePictureBox.Visible = false;
		}

		private void showBackButton_Click(object sender, EventArgs e)
		{
			cardBackPictureBox.Visible = true;
			cardFacePictureBox.Visible = false;
		}

		private void showFaceButton_Click(object sender, EventArgs e)
		{
			cardBackPictureBox.Visible = false;
			cardFacePictureBox.Visible = true;
		}
	}
}