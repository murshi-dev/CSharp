//demo INHERITANCE
public class Member
{
    private string name;
    private int memberID;
    private int memberSince;
    protected int annualFee;//to be shared between VIPMember and NormalMember class

    public Member(string n, int mid, int msince)
    {
        name = n;
        memberID = mid;
        memberSince = msince;
    }
    public override string ToString()
    {
        return "\n MemberName: " + name + "\n MemberID: " + memberID +
            "\n MemberSince: " + memberSince + "\n AnnualFee: " + annualFee;
    }
}//end of Member class
class NormalMember : Member
{
    public NormalMember(string n, int mid, int msince) : base(n, mid, msince)
    {
    }
    public void calculateFee()
    {
        annualFee = 100 + 12 * 30;
    }
}//end of NormalMember
class VIPMember : Member
{
    public VIPMember(string n, int mid, int msince) : base(n, mid, msince)
    { }
    public void calculateFee()
    {
        annualFee = 500 + 12 * 30;
    }
}//end of VIPMember

class Program
{
    static void Main()
    {
        NormalMember normalmember = new NormalMember("Jane", 101, 2000);
        normalmember.calculateFee();
        Console.WriteLine(normalmember.ToString());

        VIPMember vipmember = new VIPMember("Kate", 105, 2005);
        vipmember.calculateFee();
        Console.WriteLine(vipmember.ToString());
    }
}