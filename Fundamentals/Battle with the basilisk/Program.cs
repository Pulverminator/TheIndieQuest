using System;
using System.Collections.Generic;

namespace Battle_with_the_basilisk
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var random = new Random();
			List<String> fighters = new List<String> { "Jazlyn", "Theron", "Dyana", "Rolando" };
			List<int> fighterList = new List<int>();
			foreach (string fighter in fighters)
			{
				fighterList.Add(random.Next(3, 8));
			}
			Console.WriteLine($"Fighters {string.Join(", ", fighters)} descend into the dungeon.");
				// basilisk = 8d8+16 HP
			int basiliskHP = 0;
			for (int i = 0; i <= 8; i++) 
			{
				basiliskHP += random.Next(1, 9);
			}

			basiliskHP += 16;
			Console.WriteLine($"A basilisk with {basiliskHP} HP appears!");

			while (basiliskHP > 0 && fighters.Count > 0)
			{
				// greatsword = 2d6 damage
				int greatsword = 0;
				foreach (string fighter in fighters)
				{
					for (int hit = 0; hit < 1; hit++)
					{
						greatsword += random.Next(1, 7) * 2;
					}
					basiliskHP -= greatsword;
					if (basiliskHP < 0)
					{
						basiliskHP = 0;
					}
					Console.WriteLine($"{fighter} hits the basilisk for {greatsword} damage. Basilisk has {basiliskHP} left.");
					greatsword = 0;
					if (basiliskHP == 0) 
					{
						Console.WriteLine($"The basilisk collapses and the heroes celebrate their victory!");
						break;
					}
				}
			}
			Console.ReadKey();

		}
	}
}
