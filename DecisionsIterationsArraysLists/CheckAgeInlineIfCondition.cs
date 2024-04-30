//condition checking program using inline if   : ?
class CheckAgeInlineIfCondition
{
	static void Main(string[] args)
	{
		int userAge;
		//prompt to to enter the age
		Console.Write("Enter the age: ");
		//read user input and convert to integer
		userAge = Convert.ToInt32(Console.ReadLine());


		//inline if
		string message = (userAge < 0 || userAge > 100) ? "Invalid Age, Age must be between 1 to 100" :
						(userAge < 18) ? "Sorry. Under Age" :
						(userAge < 21) ? "Parental Consent Required" :
						"You may sign up for the event";

		Console.WriteLine(message);

		}
	}
