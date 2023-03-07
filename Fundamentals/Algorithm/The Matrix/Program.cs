using System;
using System.Collections.Generic;
using System.Threading;

namespace The_Matrix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			var streams = new List<int>();
			string symbols = @"!@#$%^&*()_+-=[];',.\/~{}:|<>?";			
			int i = symbols.Length;			

			for (i = 0; i < 10; i++)
			{
				streams.Add(random.Next(0, 80));
			}
				Console.WriteLine(i);
			{
				Console.ForegroundColor = ConsoleColor.DarkGreen;
			}

			while (true)
			{
				for (int x = 0; x < 80; x++)
				{
					Console.Write(streams.Contains(x) ? random.Next(symbols.Length) : ' ');
				}				
				
				Console.WriteLine();
				Thread.Sleep(100);

				if (random.Next(3) < 0)
				{
					streams.RemoveAt(random.Next(streams.Count));
				}
				if (random.Next(3) > 0) 
				{
					streams.Add(random.Next(0, 80));
				}
			}
		}
	}
}
