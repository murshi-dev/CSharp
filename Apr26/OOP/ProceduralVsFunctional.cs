//demo to diff procedural vs functional programming
class Program
{
    static void Main()
    {
        //PROCEDURAL --square numbers
        //create an array and load with few numbers
        int[] numbers = { 1, 2, 3, 4, 5 };
        //create a list to store the square of the numbers
        List<int> squared = new List<int>();

        //logic to square the numbers 
        //use foreach loop to loop through the list
        foreach (int number in numbers)
        {
            int result = number * number;
            squared.Add(result);
        }
        //display the result
        Console.WriteLine("Squared values are: ");
        Console.WriteLine(string.Join(",", squared));

        //FUNCTIONAL --square numbers --PURE FUNCTION
        int Square(int x)
        {
            return x * x;
        }
        var squaredPF = numbers.Select(Square).ToList();
        Console.WriteLine("Squared values using pure functions are: ");
        Console.WriteLine(string.Join(",", squaredPF));

        //FUNCTIONAL --square numbers --LINQ --Language Integrated Query
        var squaredLINQ = numbers.Select(x => x * x).ToList();
        //Select is a LINQ method
        Console.WriteLine("Squared values using LINQ are: ");
        Console.WriteLine(string.Join(",", squaredLINQ));
     }
}