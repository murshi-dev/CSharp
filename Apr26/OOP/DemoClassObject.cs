//demo class and object
class Staff
{
    //properties
    public string staffName;
    public int hrsWorked;
    //property with constant value
    public const int hourlyRate = 50;

    //constructor --parametrised
    public Staff(string firstName, string lastName)
    {
        staffName = firstName + " " + lastName;
    }
    //method to calculate pay
    public int calculatePay()
    {
        int pay = hrsWorked * hourlyRate;
        return pay;
    }
}
class Program
{
    static void Main()
    {
        //create object for Staff class
        Staff staff1 = new Staff("Peter", "Jane");
      
        //assign hrs worked
        staff1.hrsWorked = 10;
        
        //calculate pay
        int totalPay = staff1.calculatePay();
       
        //display result
        Console.WriteLine("Total pay: ", totalPay);
     }
}