namespace ListOperations
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		List<string> nameList = new List<string>();
		//count the elements in the list
		private void button1_Click(object sender, EventArgs e)
		{

			nameList.Add("Chris");
			nameList.Add("Kathryn");
			nameList.Add("Bill");
			MessageBox.Show("The List has " + nameList.Count + " objects stored in it.");
		}
		//display each item from the list
		private void button2_Click(object sender, EventArgs e)
		{

			for (int index = 0; index < nameList.Count; index++)
			{
				MessageBox.Show(nameList[index]);
			}

		}

		private void button3_Click(object sender, EventArgs e)
		{
			// Open the Names.txt file.
			StreamReader inputFile = File.OpenText("GirlNames.txt");

			// Create a List object to hold strings.
			List<string> girlnameList = new List<string>();

			// Read the file's contents.
			while (!inputFile.EndOfStream)
			{
				// Read a line and add it to the List.
				girlnameList.Add(inputFile.ReadLine());
			}

			foreach (string str in girlnameList)
			{
				MessageBox.Show(str);
			}


		}

		//add names to the list

		private void button4_Click(object sender, EventArgs e)
		{
			string uname = textBox1.Text;
			nameList.Insert(0, uname);
		}

		//search a name from the list
		private void button5_Click(object sender, EventArgs e)
		{
			string uname = textBox1.Text;
			// Search for the entered name
			int position = nameList.IndexOf(uname);

			// Was the name found in the List?
			if (position != -1)
			{
				MessageBox.Show(uname + " was found at index " + position);
			}
			else
			{
				MessageBox.Show(uname + " was not found.");
			}

		}
	}
}
