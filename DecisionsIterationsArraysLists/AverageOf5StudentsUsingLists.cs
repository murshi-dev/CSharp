class AverageOf5StudentsUsingLists
{
	static void Main(string[] args)
	{
		const int numberOfStudents = 5; // Number of students

		List<int> marks = new List<int>();//list to store marks

		//loop to input marks of each student
		for (int i = 1; i <= numberOfStudents; i++)
		{
			Console.WriteLine($"Enter marks for student {i}: ");
			marks.Add( Convert.ToInt32(Console.ReadLine()) );
		}
		//calculate total
		int totalMarks = 0;
		foreach (int mark in marks)
		{
			totalMarks += mark;
		}
		//calculate average
		double averageMarks = totalMarks / numberOfStudents;
		//print the average
		Console.WriteLine($"Average marks of {numberOfStudents} students: {averageMarks}");
	}
}