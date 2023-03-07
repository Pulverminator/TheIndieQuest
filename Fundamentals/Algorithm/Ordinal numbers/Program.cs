using System;

namespace OrdinalNumber
{
	class Program
	{
		Random random = new Random();
		static void Main(string[] args)
		{
			Console.WriteLine(OrdinalNumber(1));
			Console.WriteLine(OrdinalNumber(2));
			Console.WriteLine(OrdinalNumber(3));
			Console.WriteLine(OrdinalNumber(4));
			Console.WriteLine(OrdinalNumber(10));
			Console.WriteLine(OrdinalNumber(11));
			Console.WriteLine(OrdinalNumber(12));
			Console.WriteLine(OrdinalNumber(13));
			Console.WriteLine(OrdinalNumber(21));
			Console.WriteLine(OrdinalNumber(101));
			Console.WriteLine(OrdinalNumber(111));
			Console.WriteLine(OrdinalNumber(121));
			
		}

		static string OrdinalNumber(int number)
		{
			int lastDigit = number % 10;
			int secondToLastDigit = (number / 10) % 10;

			if (secondToLastDigit == 1)
			{
				return number + "th";
			}
			if (lastDigit == 1)
			{
				return number + "st";
			}
			if (lastDigit == 2)
			{
				return number + "nd";
			}
			if (lastDigit == 3)
			{
				return number + "rd";
			}
			else
			{
				return number + "th";				
			}			

		}
	}
}
