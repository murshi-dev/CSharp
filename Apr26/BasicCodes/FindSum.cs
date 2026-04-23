//Calculate the sum of two numbers entered. 
using System;
class FindSum
{
	static void Main()
	{

		//prompt the first number
		Console.WriteLine("Enter the first number: ");
		double number1=double.Parse(Console.ReadLine());

		//prompt the second number
		Console.WriteLine("Enter the second number: ");
		double number2 = double.Parse(Console.ReadLine());

		//calculate
		double sum = number1+number2;

		//display result
		Console.WriteLine("Sum of " +number1+ "and " + number2 + " is "+ sum);
		//or
		Console.WriteLine($"Sum of {number1} and {number2} is {sum}");

	}
}