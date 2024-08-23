//Calculate the sum of two numbers entered. 
class Activity1
{
    static void Main1()
    {
        Console.Write("Enter the first number: ");
        double number1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double number2 = double.Parse(Console.ReadLine());

        double sum = number1 + number2;

        Console.WriteLine($"Sum of {number1} and {number2} is {sum}");
    }
}