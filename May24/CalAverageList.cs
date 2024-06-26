//input marks in an List - calculate and 
//disply the total and average
class Program
{
    static void Main()
    {
        const int numberOfStudents = 5;
        //create list
        List<int> marks = new List<int>();

        //loop to input the marks
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"Enter marks for student{i+1}");
            //add elements to list using Add() method
            marks.Add(int.Parse(Console.ReadLine()));
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