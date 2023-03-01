using System;

namespace Tank_battle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("DANGER! A tank is approaching our position. Your artillery unit is our only hope!\n");
			Console.WriteLine("What is your name, commander?\n");
			string userName = Console.ReadLine();
			Console.WriteLine("Here is the map of the battlefield:\n");
			Console.Write("\n_/");

			var random = new Random();
			int tankDistance = random.Next(40, 71);

			for (int i = 2; i < 80; i++)
			{
				if (i == tankDistance)
				{
					Console.Write("T");
				}
				else
				{
					Console.Write("_");
				}
			}

			int shots = 5;
			bool hit = false;
			while (shots > 0 && hit == false)
			{
				Console.WriteLine("\nAim your shot, " + userName + "!");
				Console.Write("Enter distance:");
				int aim = Convert.ToInt32(Console.ReadLine());
				if (aim == tankDistance)
				{
					Console.WriteLine("B00M! Your aim is legendary and the tank is destroyed!"); shots -= 1; hit = true;
				}
				else if (aim < tankDistance)
				{
					Console.WriteLine("Ooh no, your shot was too short."); shots -= 1;
				}
				else if (aim > tankDistance)
				{
					Console.WriteLine("Alas, the shell flies past the tank."); shots -= 1;
				}

				for (int i = 0; i < 80; i++)
				{
					if (i == aim)
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(" ");
					}
				}
				if (aim > 80)
				{
					Console.WriteLine("\nYou aiming outside the battlefield, try a shorter distance!");
				}
			}
		}
	}
}
