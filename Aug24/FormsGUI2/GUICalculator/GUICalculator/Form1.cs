namespace GUICalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                int addValue;
                //convert the values from text box to inreger values using parse
                addValue = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);

                //pass the added value to the result label
                label4.Text = addValue.ToString();
            }
            catch
            {
                MessageBox.Show("invalid input");
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int mulValue;
                //convert the values from text box to inreger values using parse
                mulValue = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);

                //pass the added value to the result label
                label4.Text = mulValue.ToString();
            }
            catch
            {
                MessageBox.Show("invalid input");
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
        }
    }
}
