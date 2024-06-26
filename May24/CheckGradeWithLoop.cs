//code to check marks and sisplay relevant grade
//use sentinel controlled repetition
class Program
{
    static void Main()
    {
        string option = "y";
        while (option=="Y" || option=="y") 
            {
                Console.WriteLine("Enter the marks: ");
                int marks = int.Parse(Console.ReadLine());
                if (marks < 0)
                {
                    Console.WriteLine("Marks cannot be negative number!");
                }
                else if (marks >= 80)
                {
                    Console.WriteLine("Grade is A");
                }
                else if (marks >= 50)
                {
                    Console.WriteLine("Grade is B");
                }
                else
                {
                    Console.WriteLine("Grade is F");
                }
            Console.WriteLine("Continue (Y/N): ");
            option = Console.ReadLine().ToString();
        }
    }
}