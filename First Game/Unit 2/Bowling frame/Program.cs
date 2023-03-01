using System;

namespace Bowling_frame
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var random = new Random();
			int firstRoll = random.Next(0, 11);
			int pinsLeft = 10 - firstRoll;
			int secondRoll = random.Next(0, pinsLeft + 1);
			Console.WriteLine($"First roll is: {firstRoll}");
			Console.WriteLine($"Second roll is: {secondRoll}");
			Console.ReadKey();
		}
	}
}
