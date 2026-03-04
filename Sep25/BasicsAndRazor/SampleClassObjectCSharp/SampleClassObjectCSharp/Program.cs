using SampleClassObjectCSharp;
using System;
class Program
{
    static void Main()
    {
        //create object for the Product class
        Product product = new Product();

        //assign values to attributes using the object
        product.ProductName = "Notebook";
        product.ProductPrice = 100;
        product.Quantity = 2;

        //call the method using the object
        double total = product.calTotal();

        //display output
        Console.WriteLine($"ProductName: {product.ProductName}");
        Console.WriteLine($"ProductPrice: {product.ProductPrice}");
        Console.WriteLine($"Quantity: {product.Quantity}");
        Console.WriteLine($"Total Amount: {total}");
    }
}