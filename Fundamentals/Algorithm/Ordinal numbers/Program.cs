using System;

namespace OrdinalNumber
{
	class Program
	{
		Random random = new Random();
		static void Main(string[] args)
		{
			OrdinalNumber();			
		}

		static string OrdinalNumber(int number)
		{
			Console.WriteLine(number);
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
