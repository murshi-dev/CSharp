/*3.Write a program that: Accepts a grade (A, B, C, D, F). Display--
o	A → Excellent 
o	B → Good 
o	C → Average 
o	D → Poor 
o	Default → Fail	--use switch structure */
class Program
{
    static void Main()
    {
        string grade;
        Console.Write("Enter the grade: ");
        grade = Console.ReadLine();

        switch (grade)
        {
            case "A":
                Console.WriteLine("Excellent");
                break;
            case "B":
                Console.WriteLine("Good");
                break;
            case "C":
                Console.WriteLine("Average");
                break;
            case "D":
                Console.WriteLine("Poor");
                break;
            default:
                Console.WriteLine("Fail");
                break;
        }
    }
}

