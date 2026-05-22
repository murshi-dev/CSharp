namespace Tutorial3
{
    public partial class cardIdentifier : Form
    {
        public cardIdentifier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void spade2_Click(object sender, EventArgs e)
        {
            answerBox.Text = "2 Spade";
        }

        private void heart7_Click(object sender, EventArgs e)
        {
            answerBox.Text = "7 Heart";
        }

        private void clubs10_Click(object sender, EventArgs e)
        {
            answerBox.Text = "10 Clubs";
        }

        private void kingSpade_Click(object sender, EventArgs e)
        {
            answerBox.Text = "King Spade";
        }

        private void aceSpade_Click(object sender, EventArgs e)
        {
            answerBox.Text = "Ace Spade";
        }
    }
}
