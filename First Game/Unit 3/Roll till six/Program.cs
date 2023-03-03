using System;

namespace Roll_till_six
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var random = new Random();
			int throwDice;
			int score = 0;
			do
			{
				throwDice = random.Next(1, 7);
				Console.WriteLine($"Player rolls: {throwDice}");
				score += throwDice;
			} 
			while (throwDice != 6);
			Console.WriteLine($"Total score: {score}");
		}
	}
}
