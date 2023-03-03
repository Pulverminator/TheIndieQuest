using System;
using System.Collections.Generic;
using System.Net;

namespace Combat_simulator
{
	internal class Program
	{
		static Random random = new Random();
		static void SimulateCombat(List<string> characterNames, string monsterName, int monsterHP, int savingThrowDC)

		{
			
			Console.WriteLine($"Watch out, {monsterName} with {monsterHP} HP appears!");

			while (monsterHP > 0 && characterNames.Count > 0)
			{
				//Heroes attack
				int greatsword = 0;
				foreach (string fighter in characterNames)
				{
					greatsword = DiceRoll(2, 6);
					monsterHP -= greatsword;
					if (monsterHP < 0)
					{
						monsterHP = 0;
					}
					Console.WriteLine($"{fighter} hits the {monsterName} for {greatsword} damage. {monsterName} has {monsterHP} left.");
					greatsword = 0;
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
				int savingThrow = DiceRoll(1, 21);

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
				Console.WriteLine($"The party has failed and the {monsterName} continues to turn unsuspecting adventurers to ash.");
			}
		}

		static int DiceRoll(int numberOfRolls, int diceSides, int fixedBonus = 0)
		{
			int result = 0;
			for (int i = 0; i < numberOfRolls; i++)
			{

				result = result + random.Next(1, diceSides + 1);
			}
			return result += fixedBonus;

			// Roll X dice
			// Sum their results together
			// add the fixed bonus


		}

		static void Main(string[] args)
		{

			List<String> fighters = new List<String> { "Jazlyn", "Theron", "Dyana", "Rolando" };
			Console.WriteLine($"Fighters {string.Join(", ", fighters)} descend into the dungeon.");
			//Monsters
			int orcHP = DiceRoll(2, 8, 6);
			int azerHP = DiceRoll(6, 8, 12);
			int trollHP = DiceRoll(8, 10, 40);
			SimulateCombat(fighters, "Orc", orcHP, 10);

			if (fighters.Count >= 1)
			{
				SimulateCombat(fighters, "Azer", azerHP, 18);
			}

			if (fighters.Count >= 1)
			{
				SimulateCombat(fighters, "Troll", trollHP, 16);
			}

			if (fighters.Count >= 1)
			{
				Console.WriteLine($"After three grueling battles, the heroes {string.Join(", ", fighters)} return from the dungeons to live another day.");
			}

			Console.ReadKey();
		}
	}
}
