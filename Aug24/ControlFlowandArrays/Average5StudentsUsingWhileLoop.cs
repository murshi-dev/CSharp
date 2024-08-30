//input 5 students marks using while loop -- calculate and display the average 
class Average5StudentsUsingWhileLoop
{
	static void Main(string[] args)
	{
		const int numberOfStudents = 5; // Number of students
		int totalMarks = 0; // Variable to store the total marks
		int i = 1; // Initialize the loop counter

		// Loop to input marks for each student using a while loop
		while (i <= numberOfStudents)
		{
			Console.Write($"Enter marks for student {i}: ");
			int marks = Convert.ToInt32(Console.ReadLine());
			totalMarks += marks; // Add the current student's marks to the total
			i++; // Increment the loop counter
		}

		// Calculate the average marks
		double averageMarks = totalMarks / numberOfStudents;

		// Print the average marks
		Console.WriteLine($"Average marks of {numberOfStudents} students: {averageMarks}");

	}
}

