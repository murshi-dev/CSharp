class AverageOf5StudentsUsingArrays
{
	static void Main(string[] args)
	{
		const int numberOfStudents = 5; // Number of students

		int[] marks = new int[numberOfStudents];// array to store the marks

		//loop to input marks of each student
		for (int i = 0; i < numberOfStudents; i++)
		{
			Console.WriteLine($"Enter marks for student {i+1}: ");
			marks[i] = Convert.ToInt32(Console.ReadLine());//store each data in array
		}
		//calculate total
		int totalMarks = 0;
		foreach (int mark in marks) 
		{
			totalMarks += mark;
		}
		//calculate average
		double averageMarks=totalMarks/numberOfStudents;
		//print the average
		Console.WriteLine($"Average marks of {numberOfStudents} students: {averageMarks}");
	}
}