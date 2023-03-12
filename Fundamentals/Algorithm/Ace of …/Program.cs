using System;
using System.Text;

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
		enum Rank
		{
			Two,
			Three,
			Four,
			Five,
			Six,
			Seven,
			Eight,
			Nine,
			Ten,
			Jack,
			Queen,
			King,
			Ace
		}


		static void DrawAce(Suit suit)
		{
			if (suit == Suit.Spade) 
			{ 
				Console.WriteLine("╭───────╮\r\n│A      │\r\n│♠      │\r\n│   ♠   │\r\n│      ♠│\r\n│      A│\r\n╰───────╯\r\n");
			}
			if (suit == Suit.Heart)
			{
				Console.WriteLine("╭───────╮\r\n│A      │\r\n│♥      │\r\n│   ♥   │\r\n│      ♥│\r\n│      A│\r\n╰───────╯\r\n");
			}
			if (suit == Suit.Diamond)
			{
				Console.WriteLine("╭───────╮\r\n│A      │\r\n│♦      │\r\n│   ♦   │\r\n│      ♦│\r\n│      A│\r\n╰───────╯\r\n");
			}
			if (suit == Suit.Club)
			{
				Console.WriteLine("╭───────╮\r\n│A      │\r\n│♣      │\r\n│   ♣   │\r\n│      ♣│\r\n│      A│\r\n╰───────╯\r\n");
			}
		}



		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			DrawAce(Suit.Spade);
			DrawAce(Suit.Heart);
			DrawAce(Suit.Diamond);
			DrawAce(Suit.Club);
		}
	}
}
