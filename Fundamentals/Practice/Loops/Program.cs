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

			Console.WriteLine("\nDraw a square with side n with every other row blank. " + n);
			DrawSquareOtherBlank(n);

			Console.WriteLine("\nDraw a square with side n with every other column blank. " + n);
			quareWithside(n);

			Console.WriteLine("\nDraw a grid with side n with a line on every other row and every other column. " + n);
			DrawNine(n);




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
			for (int i = n; i >= 0; i--)
			{
				Console.WriteLine(new string('#', n - i));
			}
		}

		static void DrawParallelogram(int n) // Draw a parallelogram with height n.
		{
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(new string('.', n - i - 1) + new string('#', n));
			}
		}

		static void DrawIsoscelesTriangle(int n) // Draw an Isosceles triangle with height n and base 2n-1.
		{
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(new string('.', n - i - 1) + new string('#', 2 * i + 1));
			}
		}
		static void DrawSquareOtherBlank(int n) // Draw a square with side n with every other row blank.
		{
			for (int y = 0; y < n; y++)
			{
				for (int x = 0; x < n; x++)
				{
					if (y % 2 == 0)
					{
						Console.Write("#");  //#
					}
					else
					{
						Console.Write(".");  //.

					}
				}
				Console.WriteLine();
			}
		}
		static void quareWithside(int n) // Draw a square with side n with every other column blank.
		{
			for (int y = 0; y < n; y++)
			{
				for (int x = 0; x < n; x++)
				{
					if (x % 2 == 0)
					{
						Console.Write("#");  //#
					}
					else
					{
						Console.Write(".");  //.

					}
				}
				Console.WriteLine();
			}
		}
		static void DrawNine(int n) // Draw a grid with side n with a line on every other row and every other column.
		{
			for (int y = 0; y < n; y++)
			{
				for (int x = 0; x < n; x++)
				{
					if (y % 2 == 0)
					{
						Console.Write("#");  //#
					}
					else if (x % 2 == 1)
					{
						Console.Write(".");  //.
					}
				}
				Console.WriteLine();
			}
		}
	}

}
