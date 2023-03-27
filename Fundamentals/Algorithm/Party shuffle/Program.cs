using System;
using System.Collections.Generic;

namespace Party_shuffle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> names = new List<string>
			{
				"Allie",
				"Ben",
				"Claire",
				"Dan",
				"Eleanor"
			};
			PrintList(names);
			Console.WriteLine("Signed-up participants: " + string.Join(", ", names));
			Console.WriteLine();
			Console.Write("Generating starting order ...");
			ShuffleList(names);
			Console.WriteLine();
			Console.Write("\nStarting order: " + string.Join(", ", (names)));
			Console.ReadKey();
		}

		static void PrintList(List<string> items)
		{
			foreach (string item in items)
			{
				Console.Write(item);
			}
		}

		static void ShuffleList(List<string> items)
		{
			Random random = new Random();
			for (int i = items.Count - 1; i > 0; i--)
			{
				int j = random.Next(i + 1);
				string temp = items[i];
				items[i] = items[j];
				items[j] = temp;
			}
		}
	}
}
