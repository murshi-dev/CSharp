namespace ArrayOperations
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		// Create an array.
		int[] scores = { 92, 81, 65, 72 };
		// Declare and initialize an accumulator variable.
		int total = 0;
		// Declare a variable to hold the average.
		int average;

		private void button1_Click(object sender, EventArgs e)
		{
			for (int index = 0; index < scores.Length; index++)
			{
				total += scores[index];
			}
			// Calculate the average.
			average = total / scores.Length;
			// Display the average.
			MessageBox.Show("The average is " + average);

		}

		private void button2_Click(object sender, EventArgs e)
		{

			int highest = scores[0];
			for (int index = 1; index < scores.Length; index++)
			{
				if (scores[index] > highest)
				{
					highest = scores[index];
				}
			}

			// Display the highest value.
			MessageBox.Show("The highest value is " + highest);

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			int lowest = scores[0];
			for (int index = 1; index < scores.Length; index++)
			{
				if (scores[index] < lowest)
				{
					lowest = scores[index];
				}
			}

			// Display the highest value.
			MessageBox.Show("The lowest value is " + lowest);
		}
	}
}
