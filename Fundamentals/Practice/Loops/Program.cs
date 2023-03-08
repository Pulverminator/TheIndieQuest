using System;

namespace HashTagObjects
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter a number: ");
			int n = int.Parse(Console.ReadLine());

			Console.WriteLine("\nDrawing a line of length " + n);
			DrawLine(n);

			Console.WriteLine("\nDrawing a square with side length " + n);
			DrawSquare(n);

			Console.WriteLine("\nDrawing a right triangle with legs of length " + n);
			DrawRightTriangle(n);

			Console.WriteLine("\nDrawing a parallelogram with height " + n);
			DrawParallelogram(n);

			Console.WriteLine("\nDrawing an isosceles triangle with height " + n);
			DrawIsoscelesTriangle(n);

			Console.ReadLine();
		}

		static void DrawLine(int n) // Draw a line n long.
		{
			for (int i = 0; i < n; i++)
			{
				Console.Write("#", n);
			}
		}

		static void DrawSquare(int n)  // Draw a square with side n.
		{
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(new string('#', n));
			}
		}

		static void DrawRightTriangle(int n) // Draw a right triangle with legs size n.
		{
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(new string('#', n - i));
			}
		}

		static void DrawParallelogram(int n) // Draw a parallelogram with height n.
		{
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(new string('.', n - i) + new string('#', n));
			}
		}

		static void DrawIsoscelesTriangle(int n) // Draw an Isosceles triangle with height n and base 2n-1.
		{
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(new string('.', n - i - 1) + new string('#',  2 * i + 1));
			}
		}









	}
}
