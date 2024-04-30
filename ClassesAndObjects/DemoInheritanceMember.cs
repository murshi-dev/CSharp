//inheritance - reusing existing classes
using System;
public class Member
{
	protected int annualFee;//can be accessed by derived classes
	private string name;
	private int memberId;
	private int memberSince;

	//override tostring for a string represenation of the object
	public override string ToString()
	{
		return "Name: " + name + "\nMemberID: " + memberId + "\nMember Since: " + memberSince + "\nAnnual Fee: " + annualFee;
	}
	//constructor
	public Member(string pName, int pmemberId, int pmemberSince)
	{
		name= pName;
		memberId= pmemberId;
		memberSince= pmemberSince;
	}
}
//derive a class NormalMember from Member - INHERIT
class NormalMember : Member
{
	//constructor
	//this constructor does not have any logic inside as the base class initilises the fields
	public NormalMember(string remarks, string name,int memberId,int memberSince):base(name,memberId,memberSince)
	{ }
	//calculate the annual fee
	public void CalculateAnnualFee()
	{
		annualFee = 100 + 12 * 30;
	}
}
//derive a class VIPMember from Member - INHERIT
class VIPMember : Member
{
	//constructor
	//this constructor does not have any logic inside as the base class initilises the fields
	public VIPMember(string name, int memberId, int memberSince) : base(name, memberId, memberSince)
	{ }
	//calculate the annual fee
	public void CalculateAnnualFee()
	{
		annualFee = 500 + 12 * 30;
	}
}

class DemoInheritanceMember
{
	static void Main(string[] args)
	{
		//create objects for derived classes
		NormalMember mem1 = new NormalMember("Special rate", "John", 1001, 2020);
		VIPMember mem2 = new VIPMember("Amy", 1002, 2023);

		//call the methods using the objects
		mem1.CalculateAnnualFee();
		mem2.CalculateAnnualFee();

		//display the result
		Console.WriteLine(mem1.ToString());
		Console.WriteLine(mem2.ToString());
	}
}