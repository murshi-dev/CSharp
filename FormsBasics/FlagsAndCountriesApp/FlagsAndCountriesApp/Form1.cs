namespace FlagsAndCountriesApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void finlandPictureBox_Click(object sender, EventArgs e)
		{
			countryLabel.Text = "Finland";
		}

		private void germanyPictureBox_Click(object sender, EventArgs e)
		{
			countryLabel.Text = "Germany";
		}

		private void francePictureBox_Click(object sender, EventArgs e)
		{
			countryLabel.Text = "France";
		}
	}
}