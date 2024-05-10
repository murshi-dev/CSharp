namespace CalculatorTextWithParse
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
				//retrieve values from text box, convert into int and then add
				addValue = int.Parse(n1TextBox.Text) + int.Parse(n2TextBox.Text);
				//display the result
				resultLabel.Text = addValue.ToString();
			}
			catch 
			{
				MessageBox.Show("Enter numbers only!");
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			n1TextBox.Text = n2TextBox.Text = resultLabel.Text = "";
		}

		private void multiplyButton_Click(object sender, EventArgs e)
		{
			try
			{
				int prodValue;
				//retrieve values from text box, convert into int and then add
				prodValue = int.Parse(n1TextBox.Text) * int.Parse(n2TextBox.Text);
				//display the result
				resultLabel.Text = prodValue.ToString();
			}
			catch
			{
				MessageBox.Show("Enter numbers only!");
			}
		}
	}
}