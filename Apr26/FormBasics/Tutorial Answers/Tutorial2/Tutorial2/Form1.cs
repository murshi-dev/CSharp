namespace Tutorial2
{
    public partial class clickableNumber : Form
    {
        public clickableNumber()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One","Number");
        }

        private void num2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Two", "Number");
        }

        private void num3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Three", "Number");
        }

        private void num4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Four", "Number");
        }

        private void num5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Five", "Number");
        }
    }
}
