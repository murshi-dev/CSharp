//polymorphism - one function mutiple function definitions 
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
	//virtual method to calculate annual fee - default implementation
	public virtual void CalculateAnnualFee()
	{
		annualFee = 0;//default annual fee
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
	public override void CalculateAnnualFee()
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
	public override void CalculateAnnualFee()
	{
		annualFee = 500 + 12 * 30;
	}
}

class DemoPolymorphismMember
{
	static void Main(string[] args)
	{

		//create an array of Member type and add 5 members to it
		Member[] clubMembers = new Member[5];
		//initialise
		clubMembers[0] = new NormalMember("Special Rate", "James", 1, 2020);
		clubMembers[1] = new NormalMember("Normal Rate", "Andy", 2, 2021);
		clubMembers[2] = new NormalMember("Normal Rate", "Bill", 3, 2021);
		clubMembers[3] = new VIPMember("Carol", 4, 2022);
		clubMembers[4] = new VIPMember("Evelyn", 5, 2023);

		//use polymorphism to calculate and display annual fee for each member
		foreach (Member member in clubMembers)
		{
			member.CalculateAnnualFee();//polymorphic method call
										//output
			Console.WriteLine(member.ToString());
		}

	}
}