namespace Tutorial5
{
    public partial class headsOrTails : Form
    {
        public headsOrTails()
        {
            InitializeComponent();
        }

        private void headsButton_Click(object sender, EventArgs e)
        {
            headsPictureBox.Visible = true;
            tailsPictureBox.Visible = false;
        }

        private void tailsButton_Click(object sender, EventArgs e)
        {
            tailsPictureBox.Visible = true;
            headsPictureBox.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
