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
        Console.WriteLine("\n" + nameOfStaff);
    }
}//end staff class

class Program
{ 
    static void Main()
    {
        Staff staff1 = new Staff("Jane", "Smith");
        staff1.HoursWorked = 50;
        int pay = staff1.CalculatePay();
        Console.WriteLine("Pay " + pay);
    }
}
