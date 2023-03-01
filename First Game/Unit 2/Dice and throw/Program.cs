using System;

namespace Unit2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var random = new Random();
			int diceThrowOne = random.Next(1, 7);
			int diceThrowTwo = random.Next(1, 7);
			int diceThrowThree = random.Next(1, 7);
			int totalScore = ((diceThrowOne + diceThrowTwo) + (diceThrowThree * 3)) * 2;
			Console.WriteLine($"You roll: {diceThrowThree},{diceThrowTwo},{diceThrowThree}");
			Console.WriteLine($"Your total score is: {totalScore}");
		}
	}
}
