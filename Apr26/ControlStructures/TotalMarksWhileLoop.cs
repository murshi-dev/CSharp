/*5.Write a program to: Input marks for 5 students, calculate and display the average
Use WHILE loop.
 */
class Program
{
    static void Main()
    {
        int numberOfStudents = 5;
        int totalMarks = 0;
        int counter = 1;//RULE 1 --start value 
        while (counter <= numberOfStudents)//RULE 2 --stop value
        {
            Console.WriteLine($"Enter marks of student{counter}: ");
            int marks = Convert.ToInt32( Console.ReadLine() );
            totalMarks += marks;
            counter++;//RULE 3 --update value
        }
        double averageMarks = (double)totalMarks / numberOfStudents;

        Console.WriteLine( $"Total marks: {totalMarks}" );
        Console.WriteLine($"Average marks: {averageMarks}");
    }
}

