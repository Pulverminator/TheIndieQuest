using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GenerateCharacters
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var rollMem = new List<int>();
			var rollTotalMem = new List<int>();
			var random = new Random();
			int rollTotal = 0;
			int roll = 0;
			for (int i = 0; i < 6; i++)
			{

				for (int d = 0; d < 4; d++)
				{
					roll = random.Next(1, 7);
					rollTotal += roll;
					rollMem.Add(roll);
				}
				Console.WriteLine();
				Console.Write("You roll ");
				foreach (var dice in rollMem)
					Console.Write(dice);
				Console.WriteLine($"{string.Join(", ", roll)}");
				int lowest = rollMem.Min();
				rollTotal -= lowest;
				rollMem.Remove(lowest);
				rollTotalMem.Add(rollTotal);
				rollTotalMem.Sort();
				Console.WriteLine($"The ability score is {string.Join(", ", rollTotal)} ");
				rollMem.Clear();
			}
			Console.WriteLine($"{string.Join(", ", rollTotal)}");
			Console.Write("Your available ability scores are ");
			foreach (var dice in rollTotalMem)
				Console.Write($"{dice} ");
			Console.WriteLine();
		}
		

	}
}
