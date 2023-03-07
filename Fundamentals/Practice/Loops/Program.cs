using System;

namespace HashTagObjects
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter a number: ");
			int size = int.Parse(Console.ReadLine());

			Console.WriteLine("Drawing a line of length " + size + ":");
			DrawLine(size);

			Console.WriteLine("\nDrawing a square with side length " + size + ":");
			DrawSquare(size);

			Console.WriteLine("\nDrawing a right triangle with legs of length " + size + ":");
			DrawRightTriangle(size);

			Console.WriteLine("\nDrawing a parallelogram with height " + size + ":");
			DrawParallelogram(size);

			Console.WriteLine("\nDrawing an isosceles triangle with height " + size + ":");
			DrawIsoscelesTriangle(size);

			Console.ReadLine();
		}

		static void DrawLine(int size)
		{
			for (int i = 0; i < size; i++)
			{
				Console.WriteLine(new string('#', size));
			}
		}

		static void DrawSquare(int size)
		{
			for (int i = 0; i < size; i++)
			{
				Console.WriteLine(new string('#', size));
			}
		}

		static void DrawRightTriangle(int size)
		{
			for (int i = 0; i < size; i++)
			{
				Console.WriteLine(new string(' ', size - i - 1) + new string('#', i + 1));
			}
		}

		static void DrawParallelogram(int size)
		{
			for (int i = 0; i < size; i++)
			{
				Console.WriteLine(new string(' ', i) + new string('#', size));
			}
		}

		static void DrawIsoscelesTriangle(int size)
		{
			for (int i = 0; i < size; i++)
			{
				Console.WriteLine(new string(' ', size - i - 1) + new string('#', 2 * i + 1));
			}
		}
	}
}
