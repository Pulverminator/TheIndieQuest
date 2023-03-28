using System;


namespace Party_dilemma
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] randomNumbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			foreach (int number in randomNumbers)
			{
				int result = Factorial(number);
				Console.WriteLine($"{number} != {result}");
			}
			Console.ReadKey();
		}

		static int Factorial(int n)
		{
			if (n == 0)
			{
				return 1;
			}
			else
			{
				return n * Factorial(n - 1);
			}
		}
	}
}

