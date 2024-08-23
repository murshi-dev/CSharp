//Calculate the amount to be paid after sales tax due on a purchase. Sales tax is 6%.
class Activity4
{
    static void Main()
    {
        Console.WriteLine("Please enter the purchase amount:");
        double purchaseAmount = double.Parse(Console.ReadLine()); // Parse purchase amount

        double salesTaxRate = 0.06; // Sales tax rate (6%)
        double salesTaxAmount = purchaseAmount * salesTaxRate; // Calculate sales tax amount

        double totalAmount = purchaseAmount + salesTaxAmount; // Calculate total amount to be paid

        Console.WriteLine($"Total amount to be paid after sales tax: {totalAmount}"); // Output the result



    }
}