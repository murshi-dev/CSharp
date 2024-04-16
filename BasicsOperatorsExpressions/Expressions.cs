class Expressions
{
	static void Main()
	{
		
		int a = 5;
		int b = 3;
		//arithemtic expression
		int result =(a + b)*(a-b)/(a*b);
		Console.WriteLine("Arithmetic Expression result: " + result);
		
		//boolean expression
		bool isTrue=(a>b) && (b>a);
		Console.WriteLine("Boolean Expression result: " + isTrue);

		//conditional expression
		int max=(a>b)?a:b;
		Console.WriteLine("Conditional Expression result: " + max);


	}
}