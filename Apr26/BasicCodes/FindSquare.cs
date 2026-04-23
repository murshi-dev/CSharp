//Calculate the square(double the value) of an entered number.
using System;
class FindSquare
{
	static void Main()
	{
		Console.WriteLine("Enter any number:");
		int number = int.Parse(Console.ReadLine()); // Parse the input as a double

		int square = number * number; // Calculate the square (double the value)

		Console.WriteLine($"The square of {number} is: {square}"); // Output the result

	}
}