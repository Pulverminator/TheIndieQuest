using System;
using System.Numerics;

namespace Regenerate_spell
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var random = new Random();
			int warriorHp = random.Next(1, 100);
			Console.WriteLine($"Warrior HP: {warriorHp}");
			Console.WriteLine($"The Regenerate spell is cast!");
			while (warriorHp < 50)
			{
				warriorHp += 10;
				Console.WriteLine($"Warrior HP: {warriorHp}");
			}

			if (warriorHp >= 50)
			{
				Console.WriteLine($"The Regenerate spell is complete!");
			}

		}
	}
}
