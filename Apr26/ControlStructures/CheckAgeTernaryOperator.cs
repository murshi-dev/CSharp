/*2.Write a C# program to: Accept user age. Display: 
o	“Invalid Age” if < 0 or > 120 
o	“Free Ticket” if age < 5 
o	“Child Ticket” if age 5–12 
o	“Standard Ticket” if age 13–59 
o	“Senior Discount” otherwise --USE TERNARY OP   ? : */
class Program
{
    static void Main()
    {
        int age = 0;
        Console.Write("Enter the age: ");
        age = Convert.ToInt32(Console.ReadLine());

        string message = (age < 0 || age > 120) ? "Invalid Age" :
                            (age <= 5) ? "Free Ticket" :
                               (age <= 12) ? "Child Ticket" :
                                   (age <= 59) ? "Standard Ticket" :
                        "Senior Disount";
        Console.WriteLine(message);
    }
}

