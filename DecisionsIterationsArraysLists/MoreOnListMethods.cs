class MoreOnListMethods
{
	static void Main(string[] args)
	{
		// Create a List to store integers
		List<int> numbers = new List<int>();

		// Add elements to the list using Add() method
		numbers.Add(10);
		numbers.Add(20);
		numbers.Add(30);
		numbers.Add(40);
		numbers.Add(50);

		// Display the count of elements using Count property
		Console.WriteLine($"Count of elements in the list: {numbers.Count}");

		// Insert an element at a specific index using Insert() method
		numbers.Insert(2, 25);

		// Display the elements of the list
		Console.WriteLine("Elements of the list after insertion:");
		foreach (int num in numbers)
		{
			Console.WriteLine(num);
		}

		// Remove an element from the list using Remove() method
		bool removed = numbers.Remove(30);
		Console.WriteLine($"Element 30 removed: {removed}");

		// Remove an element at a specific index using RemoveAt() method
		numbers.RemoveAt(3);

		// Check if an element exists in the list using Contains() method
		bool contains40 = numbers.Contains(40);
		Console.WriteLine($"List contains 40: {contains40}");

		// Clear all elements from the list using Clear() method
		numbers.Clear();

		// Display the count of elements after clearing the list
		Console.WriteLine($"Count of elements in the list after clearing: {numbers.Count}");
	}

}