using System;
class Operators
{
	static void Main()
	{
     // Define two numbers
        int num1 = 10;
        int num2 = 5;

        // Perform arithmetic operations
        int sum = num1 + num2; // Addition
        int difference = num1 - num2; // Subtraction
        int product = num1 * num2; // Multiplication
        int quotient = num1 / num2; // Division (integer division)
        int remainder = num1 % num2; // Modulus (remainder of division)

		// Output the results
		Console.WriteLine("Sum:" + sum);
        //or
		Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {quotient}");
        Console.WriteLine($"Remainder: {remainder}");
	}
}


