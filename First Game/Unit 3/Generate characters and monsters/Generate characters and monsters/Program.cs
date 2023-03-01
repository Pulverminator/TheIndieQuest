using System;

namespace Generate_characters_and_monsters
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			int randomNum = 0;
			for (int i = 0; i < 3; i++)
			{
				int str = random.Next(1, 7);
				randomNum = randomNum + str;
			}
			Console.WriteLine($"A character with strength {randomNum} was created.");

			int createCube = 40;
			for (int i = 0; i < 8; i++)
			{
				int withHP = random.Next(1, 11);
				createCube = withHP + createCube;
			}
			Console.WriteLine($"A gelatinous cube with {createCube} HP appears!");

			int armyOfCubes = 0;
			for (int i = 0; i < 100; i++) 
			{

				for (int j = 0; j < 8; j++)
				{
					int countArmy = random.Next(1, 11);
					armyOfCubes = armyOfCubes + countArmy;
				}
				armyOfCubes = armyOfCubes + 40;
			}
			Console.WriteLine($"Dear gods, an army of 100 cubes descends upon us with a total of {armyOfCubes}. We are doomed!");
		}


	}
}

