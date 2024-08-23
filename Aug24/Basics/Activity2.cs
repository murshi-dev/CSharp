//Calculate the square of an entered number.
class Activity2
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        double number = double.Parse(Console.ReadLine()); // Parse the input as a double

        double square = number * number; // Calculate the square (double the value)

        Console.WriteLine($"The square of {number} is: {square}"); // Output the result

    }
}