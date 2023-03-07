using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace The_Matrix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			var streams = new List<int>();
			string symbols = @"!@#$%^&*()_+-=[];',.\/~{}:|<>?";
			Random random = new Random();
			for (int i = 0; i < 10; i++)
			{
				streams.Add(random.Next(0, 80));
			}
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			

			while (true)
			{
				for (int x = 0; x < 80; x++)
				{
					Console.Write(streams.Contains(x) ? symbols[random.Next(symbols.Length)].ToString() : ' ');
				}				
				
				Console.WriteLine();
				Thread.Sleep(100);

				if (random.Next(3) <= 0)
				{
					streams.RemoveAt(random.Next(streams.Count));
				}
				if (random.Next(3) >= 0) 
				{
					streams.Add(random.Next(0, 80));
				}
			}
		}
	}
}
