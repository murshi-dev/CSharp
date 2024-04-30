//condition checking program
class CheckAgeIfCondition
{
	static void Main(string[] args)
	{
		int userAge;
		//prompt to to enter the age
		Console.Write("Enter the age: ");
		//read user input and convert to integer
		userAge = Convert.ToInt32(Console.ReadLine());
		//check if age is outside the valid range
		if(userAge < 0 || userAge >100) 
		{
			Console.WriteLine("Invalid Age, Age must be between 1 to 100");
		}
		else if(userAge <18) 
		{
			Console.WriteLine("Sorry. Under Age");
		}
		else if (userAge < 21)
		{
			Console.WriteLine("Parental Consent Required");
		}
		else
		{
			Console.WriteLine("You may sign up for the event");

		}
	}
}