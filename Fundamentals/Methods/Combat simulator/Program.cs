using System;
using System.Collections.Generic;

namespace Combat_simulator
{
	internal class Program
	{
		static Random random = new Random();

		static void SimulateCombat(List<string> characterNames, string monsterName, int monsterHP, int savingThrowDC)
		{

			Console.WriteLine($"A {monsterName} with {monsterHP} HP appears!");

			while (monsterHP > 0 && characterNames.Count > 0)
			{
				//Heroes attack
				int dagger = 0;
				foreach (string fighter in characterNames)
				{
					for (int hit = 0; hit < 2; hit++)
					{
						dagger += random.Next(1, 7); //changed to 2d6 from 1d4
					}
					monsterHP -= dagger;
					if (monsterHP < 0)
					{
						monsterHP = 0;
					}
					Console.WriteLine($"{fighter} hits the {monsterName} for {dagger} damage. {monsterName} has {monsterHP} left.");
					dagger = 0;
					if (monsterHP == 0)
					{
						break;
					}
				}

				if (monsterHP == 0)
				{
					break;
				}

				//Monster attack
				int targetIndex = random.Next(characterNames.Count);
				string target = characterNames[targetIndex];
				Console.WriteLine($"The {monsterName} attacks {target}!");

				//DC 12 Constitution saving throw
				int savingThrow = random.Next(1, 21);

				if (savingThrow + 3 >= savingThrowDC)
				{
					Console.WriteLine($"{target} rolls a {savingThrow} and is saved from the attack.");
				}
				else
				{
					characterNames.Remove(target);
					Console.WriteLine($"{target} rolls a {savingThrow} and is killed.");
				}
			}

			if (monsterHP == 0)
			{
				Console.WriteLine($"The {monsterName} collapses and the heroes celebrate their victory!");
			}
			else
			{
				Console.WriteLine($"The party has failed and the {monsterName} continues to turn unsuspecting adventurers to dust.");
			}
		}

		static void Main(string[] args)
		{

			List<String> fighters = new List<String> { "Jazlyn", "Theron", "Dyana", "Rolando" };
			Console.WriteLine($"Fighters {string.Join(", ", fighters)} descend into the dungeon.");
			//Monsters

			SimulateCombat(fighters, "Orc", 15, 10);

			if (fighters.Count >= 1)
			{
				SimulateCombat(fighters, "Azer", 39, 18);
			}

			if (fighters.Count >= 1)
			{
				SimulateCombat(fighters, "Troll", 84, 16);
			}

			if(fighters.Count >= 1)
			{
				Console.WriteLine($"After three grueling battles, the heroes {string.Join(", ", fighters)} return from the dungeons to live another day.");
			}
			

			Console.ReadKey();
		}
	}
}
