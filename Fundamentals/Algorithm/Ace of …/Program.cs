using System;

namespace Ace_of__
{
	internal class Program
	{
		enum Suit
		{
			Heart,
			Spade,
			Diamond,
			Club
		}

		static void DrawAce()
		{
			Console.WriteLine("╭───────╮\r\n│A      │\r\n│♠      │\r\n│   ♠   │\r\n│      ♠│\r\n│      A│\r\n╰───────╯\r\n");
		}



		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			DrawAce();
		}
	}
}
