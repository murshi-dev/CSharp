class FirstCode
{
	static void Main()
	{
		Console.WriteLine("Hello World from C#!");
		//prompt for  name
		Console.WriteLine("Enter a name: ");
		//accept the entered name and store in a variable
		string uname = Console.ReadLine();

		//prompt for age
		Console.WriteLine("Enter the age: ");
		//accept the entered age and store in a variable
		//type cast the entered age to an int value
		int age = Convert.ToInt32(Console.ReadLine());

		//display the name in the console
		Console.WriteLine("Dear " + uname + " Welcome to C#");
		//display the age in the console
		Console.WriteLine("Your age is " + age);
	}
}