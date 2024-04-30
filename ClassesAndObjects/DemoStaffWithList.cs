using System; // Importing the System namespace

public class StaffList// Defining the Staff class
{
	private string nameOfStaff; // Declaring a private field to store the name of the staff
	private const int hourlyRate = 30; // Declaring a constant field to store the hourly rate
	private int hWorked; // Declaring a private field to store the number of hours worked

	// Declaring a property to get and set the number of hours worked
	public int HoursWorked
	{
		get { return hWorked; } // Getter returns the number of hours worked
		set { hWorked = value > 0 ? value : 0; } // Setter ensures the value is non-negative
	}

	// Method to print a message indicating that pay calculation is in progress
	public void PrintMessage()
	{
		Console.WriteLine("Calculating Pay..."); // Outputting a message to the console
	}

	// Method to calculate the staff's pay based on the hours worked
	public int CalculatePay()
	{
		PrintMessage(); // Calling the PrintMessage method to print a message
		int staffPay = hWorked * hourlyRate; // Calculating the staff's pay
		return hWorked > 0 ? staffPay : 0; // Returning the staff's pay or 0 if no hours worked
	}

	// Method to override the ToString method and provide a string representation of the Staff object
	public override string ToString()
	{
		return "Name of Staff = " + nameOfStaff + ", hourlyRate = " + hourlyRate + ", hWorked = " + hWorked;
		// Returning a string representation containing the staff's name, hourly rate, and hours worked
	}

	// Constructor to initialize a Staff object with a given first and last name
	public StaffList(string firstName, string lastName)
	{
		nameOfStaff = firstName + " " + lastName; // Combining the first and last names
		Console.WriteLine("\n" + nameOfStaff); // Outputting the staff's name to the console
	}
}

class DemoStaffWithList
{
	static void Main(string[] args) // Main method, the entry point of the program
	{
		//create a new list to store Staff objects
		List<StaffList> stafflist = new List<StaffList>();
		//add staff memebers to the list
		stafflist.Add(new StaffList("John","Doe"));
		stafflist.Add(new StaffList("Amy", "Derick"));
		stafflist.Add(new StaffList("Ken", "Mia"));

		//set the hours worked
		stafflist[0].HoursWorked = 160;
		stafflist[1].HoursWorked = 180;
		stafflist[2].HoursWorked = 150;

		int totalPay = 0;

		//calculate total pay for all staff and individual pay
		//use for each loop
		foreach(StaffList staff in stafflist)
		{
			int pay = staff.CalculatePay();
			//display individual pay
			Console.WriteLine("Pay for " + staff.ToString() + ": " + pay);
			totalPay += pay;
		}
		Console.WriteLine("Total Pay for all staff: {0} ", totalPay);
	}
}
