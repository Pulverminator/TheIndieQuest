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
				//Heroes attack
				int dagger = 0;
				foreach (string fighter in fighters)
				{
					for (int hit = 0; hit < 1; hit++)
					{
						dagger += random.Next(1, 5); //changed to 1d4 from 2d6
					}
					basiliskHP -= dagger;
					if (basiliskHP < 0)
					{
						basiliskHP = 0;
					}
					Console.WriteLine($"{fighter} hits the basilisk for {dagger} damage. Basilisk has {basiliskHP} left.");
					dagger = 0;
					if (basiliskHP == 0)
					{
						break;
					}
				}

				if (basiliskHP == 0)
				{
					break;
				}

				//Basilisk attack
				int targetIndex = random.Next(fighters.Count);
				string target = fighters[targetIndex];
				Console.WriteLine($"The basilisk uses petrifying gaze on {target}!");

				//DC 12 Constitution saving throw
				int savingThrow = random.Next(1, 21);

				if (savingThrow + 3 >= 12)
				{
					Console.WriteLine($"{target} rolls a {savingThrow} and is saved from the attack.");
				}
				else
				{
					fighters.Remove(target);
					Console.WriteLine($"{target} rolls a {savingThrow} and is turned into stone.");
				}
			}

			if (basiliskHP == 0)
			{
				Console.WriteLine($"The basilisk collapses and the heroes celebrate their victory!");
			}
			else
			{
				Console.WriteLine($"The party has failed and the basilisk continues to turn unsuspecting adventurers to stone.");
			}
		}
	}
}
