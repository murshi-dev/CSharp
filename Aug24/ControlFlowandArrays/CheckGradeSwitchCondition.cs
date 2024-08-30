//condition checking program using inline if   : ?
class CheckGradeSwitchCondition
{
	static void Main(string[] args)
	{
		string userGrade;
		//prompt to to enter the age
		Console.Write("Enter the grade: ");
		//read user input 
		userGrade = Console.ReadLine();

		//switch condition
		switch(userGrade) 
		{
			case "A+":
			case "A":
				Console.WriteLine("Distinction");
				break;
			case "B":
				Console.WriteLine("Good");
				break;
			case "C":
				Console.WriteLine("Average");
				break;
			default:
				Console.WriteLine("Fail");
				break;
		}
	}
}
