//input 5 students marks using for loop -- calculate and display the average 
class Average5StudentsUsingForLoop
{
	static void Main(string[] args) 
	{
		const int numberOfStudents = 5;
		int totalMarks = 0;

		//loop to input marks for each student
		for(int i = 1; i <= numberOfStudents; i++) 
		{
			Console.WriteLine($"Enter marks for student {i}: ");
			int marks = Convert.ToInt32( Console.ReadLine() );
			totalMarks += marks;//add current student mark to the total
		}//loop ends here
		//calculate average
		double averageMarks=totalMarks/numberOfStudents;
		//print average
		Console.WriteLine( $"Average marks of {numberOfStudents} students: {averageMarks}");
	}
}

