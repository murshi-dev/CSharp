namespace Tutorial4
{
    public partial class jokeAndPunchLine : Form
    {
        public jokeAndPunchLine()
        {
            InitializeComponent();
        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            labelControl.Text = "Why was the math book sad?";
        }

        private void punchLineButton_Click(object sender, EventArgs e)
        {
            labelControl.Text = "Because it had too many problems!";
        }
    }
}
