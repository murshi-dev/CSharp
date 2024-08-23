//Calculate the average temperature from the maximum and minimum temperature entered. 
class Activity3
{
    static void Main()
    {
        Console.WriteLine("Please enter the maximum temperature:");
        double maxTemp = double.Parse(Console.ReadLine()); // Parse max temperature

        Console.WriteLine("Please enter the minimum temperature:");
        double minTemp = double.Parse(Console.ReadLine()); // Parse min temperature

        double averageTemp = (maxTemp + minTemp) / 2; // Calculate average temperature

        Console.WriteLine($"The average temperature is: {averageTemp}"); // Output the result


    }
}