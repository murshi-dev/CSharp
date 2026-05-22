namespace Tutorial1
{
    public partial class latinTranslator : Form
    {
        public latinTranslator()
        {
            InitializeComponent();
        }

        private void sinsterButton_Click(object sender, EventArgs e)
        {
            englishTranslateAnswer.Text = "Left";
        }

        private void dexterButton_Click(object sender, EventArgs e)
        {
            englishTranslateAnswer.Text = "Right";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            englishTranslateAnswer.Text = "Center";
        }
    }
}
