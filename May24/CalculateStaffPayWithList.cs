//sample code to demo class properties and objects
//calculate staff pay based on hours worked

class Staff
{
    private string nameOfStaff;
    private const int hourlyRate = 30;
    private int hWorked;
    //declare a property to get and set the hours worked
    public int HoursWorked
    {
        get { return hWorked; }//returns the numbe rof hours worked
        set { hWorked = value > 0 ? value : 0; }//ensures the value is non negative
    }
    public int CalculatePay()
    {
        int staffPay = hWorked * hourlyRate;
        return staffPay;
    }
    //override the ToString method
    public override string ToString()
    {
        return "StaffName: " + nameOfStaff + "HourlyRate: " + hourlyRate + "HoursWorked: " + hWorked;
    }
    public Staff(string firstName, string lastName)
    {
        nameOfStaff = firstName + lastName;
       // Console.WriteLine("\n" + nameOfStaff);
    }
}//end staff class

class Program
{ 
    static void Main()
    {
        List<Staff> staffList = new List<Staff>();

        staffList.Add(new Staff("J", "Smith"));
        staffList.Add(new Staff("A", "Doe"));
        staffList.Add(new Staff("B", "Kate"));
        staffList.Add(new Staff("C", "Amy"));
        staffList.Add(new Staff("D", "Jane"));

        staffList[0].HoursWorked = 10;
        staffList[1].HoursWorked = 12;
        staffList[2].HoursWorked = 14;
        staffList[3].HoursWorked = 16;
        staffList[4].HoursWorked = 18;

        int totalPay = 0;

        foreach(Staff staff in staffList )
        {
            int pay = staff.CalculatePay();
            Console.WriteLine("Pay for " + staff.ToString() + " is " + pay);
            totalPay += pay;//add each pay to total pay
        }
        Console.WriteLine("Total Pay for all Staff is "+totalPay);

    }
}
