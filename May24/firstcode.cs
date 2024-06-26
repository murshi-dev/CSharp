//code to input two numbers, add the numbers
//display the result
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        double number1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double number2 = double.Parse(Console.ReadLine());

        double sum  = number1 + number2;

        Console.WriteLine($"Sum of {number1} and {number2} is {sum}");
    }
}
