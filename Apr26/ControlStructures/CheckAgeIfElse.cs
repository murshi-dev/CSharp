/*1.Write a C# program to: Accept user age. Display: 
o	“Invalid Age” if < 0 or > 120 
o	“Free Ticket” if age < 5 
o	“Child Ticket” if age 5–12 
o	“Standard Ticket” if age 13–59 
o	“Senior Discount” otherwise */
class Program
{
    static void Main()
    {
        int age = 0;
        Console.Write("Enter the age: ");
        age = Convert.ToInt32(Console.ReadLine());
        if(age<20 || age > 120)
        {
            Console.WriteLine("Invalid Age");
        }
        else if (age < 5)
        {
            Console.WriteLine("Free Ticket");
        }
    }
}
