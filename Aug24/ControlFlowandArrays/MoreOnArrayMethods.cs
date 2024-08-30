class MoreOnArrayMethods
{
	static void Main(string[] args)
	{
		// Declare and initialize an array
		int[] numbers = { 5, 2, 8, 1, 9 };

		// Print the original array
		Console.WriteLine("Original array:");
		PrintArray(numbers);

		// Get the length of the array
		int length = numbers.Length;
		Console.WriteLine($"Length of the array: {length}");

		// Create a copy of the array
		int[] copy = new int[length];
		Array.Copy(numbers, copy, length);
		Console.WriteLine("Copied array:");
		PrintArray(copy);

		// Sort the array
		Array.Sort(copy);
		Console.WriteLine("Sorted array:");
		PrintArray(copy);

		// Find the index of a specific element
		int index = Array.IndexOf(copy, 8);
		Console.WriteLine($"Index of element 8: {index}");

		Console.ReadKey();
	}

	// Helper method to print an array
	static void PrintArray(int[] arr)
	{
		foreach (var item in arr)
		{
			Console.Write($"{item} ");
		}
		Console.WriteLine();
	}

}