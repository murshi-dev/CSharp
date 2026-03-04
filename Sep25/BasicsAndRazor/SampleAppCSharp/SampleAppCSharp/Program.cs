using System;
class Program
{
    static void Main()
    {
        //data types 
        string productName = "";
        double productPrice = 0.0;
        int quantity = 0;

        //get input
        Console.Write("Enter product name: ");
        productName = Console.ReadLine();

        Console.Write("Enter product price: ");
        productPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter product quantity: ");
        quantity = Convert.ToInt32(Console.ReadLine());

        double total = productPrice * quantity;
        
        double discount = 0.0;
        if (total > 50)
            discount = 0.50;
        else if (total > 30)
            discount = 0.30;
        else
            discount = 0;

        total = total - (total * discount);

        Console.WriteLine("ProductName: " + productName);
        Console.WriteLine("ProductPrice: "+ productPrice);
        Console.WriteLine("ProductQuantity: "+ quantity);
        //Console.WriteLine("Total: "+ total);
        //or
        Console.WriteLine($"Total: {total}");
    }
}