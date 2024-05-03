namespace HelloWorldForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		//event handling code for the button click event
		
		private void button1_Click(object sender, EventArgs e)
		{
			//first param is the message
			//second param is the message box title
			MessageBox.Show("Welcome to Forms in C#","Welcome Message");
		}
	}
}