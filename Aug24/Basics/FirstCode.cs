class Program
{
    static void Mainsample()
    {
        Console.Write("Enter the name: ");
        string name =Console.ReadLine();

        Console.Write("Enter the contact number: ");
        string contact = Console.ReadLine();

        Console.Write("Enter the address: ");
        string address = Console.ReadLine();


        Console.WriteLine("Welcome to C# "+ name);
        Console.WriteLine("Other Info\t Contact: " + contact + "\t Address: " + address);
        //or
        Console.WriteLine($"Other Info\t Contact: {contact}\t Address: {address}");
    }
}