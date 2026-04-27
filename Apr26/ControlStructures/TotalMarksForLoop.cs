/*4.Write a program to: Input marks for 5 students, calculate and display the average
Use for loop.
 */
class Program
{
    static void Main()
    {
        int numberOfStudents = 5;
        int totalMarks = 0;

        for (int counter = 1; counter <= numberOfStudents; counter++)
        {
            Console.WriteLine($"Enter marks of student{counter}: ");
            int marks = Convert.ToInt32( Console.ReadLine() );
            totalMarks += marks;
        }
        double averageMarks = (double)totalMarks / numberOfStudents;

        Console.WriteLine( $"Total marks: {totalMarks}" );
        Console.WriteLine($"Average marks: {averageMarks}");
    }
}

