//input marks in an array - calculate and 
//diaply the total and average
class Program
{
    static void Main()
    {
        const int numberOfStudents = 5;
        int[] marks = new int[numberOfStudents];

        //loop to input the marks
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"Enter marks for student{i+1}");
            marks[i] = int.Parse(Console.ReadLine());
        }
        //calculate the total
        int total = 0;
        foreach (int mark in marks)
        {
            total += mark;//accumulate and total
        }
        //calculate average
        int average = total / numberOfStudents;

        Console.WriteLine($"Average marks for {numberOfStudents} is {average}");
   
    }
}