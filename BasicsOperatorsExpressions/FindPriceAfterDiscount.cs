using System;
//Calculate the amount to be paid for an apparel with a discount of 20% to its original price.
class FindPriceAfterDiscount
{
	static void Main()
	{
		Console.WriteLine("Enter the original price of the apparel:");
		double originalPrice = double.Parse(Console.ReadLine()); // Parse original price

		double discountPercentage = 0.20; // Discount percentage (20%)
		double discountAmount = originalPrice * discountPercentage; // Calculate discount amount

		double discountedPrice = originalPrice - discountAmount; // Calculate discounted price
		// Output the result
		Console.WriteLine($"Amount to be paid after 20% discount: {discountedPrice}");
	}
}
