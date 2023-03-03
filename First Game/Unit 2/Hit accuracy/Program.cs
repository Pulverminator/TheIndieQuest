using System;

namespace Hit_accuracy
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var random = new Random();
			int shots = random.Next(10, 20);
			int hits = random.Next(0, shots + 1);
			Console.WriteLine($"Total shots: {shots}");
			Console.WriteLine($"Hits made: {hits}");
			double total = (hits * 1.0) / shots;
			double accuracy = 100 * total;
			Console.WriteLine($"Hit accuracy: {accuracy}%");
			Console.ReadKey();
		}		
	}
}
