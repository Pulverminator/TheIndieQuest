using System;

namespace Bowling_frame_revised
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var random = new Random();
			int pinsLeft = 10;
			int firstRoll = random.Next(0, pinsLeft +1);
			pinsLeft = pinsLeft - firstRoll;
			if (firstRoll < 1)
			{
				Console.WriteLine($"First roll: -");
			}
			else if (firstRoll > 9) 
			{
				Console.WriteLine($"First roll: X");
			}
			else
			{
				Console.WriteLine($"First roll: {firstRoll}");
			}
			if (pinsLeft > 0)
			{
				int secRoll = random.Next(0, pinsLeft +1);
				pinsLeft = pinsLeft - secRoll;
				if (secRoll < 1)
				{
					Console.WriteLine($"Second roll: -");
				}
				else if (pinsLeft < 1)
				{
					Console.WriteLine($"Second roll: /");
				}
				else
				{
					Console.WriteLine($"Second roll: {secRoll}");
				}
				int total = firstRoll + secRoll;
				Console.WriteLine($"Knocked pins: {total}");
			}
						
		}

	}
}
