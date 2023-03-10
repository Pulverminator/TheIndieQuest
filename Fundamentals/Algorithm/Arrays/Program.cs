using System;

namespace Arrays
{
	internal class Program
	{
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


		enum season
		{
			Spring,
			Summer,
			Fall,
			Winter
		}
		enum day
		{
			Monday = 0,
			Tuesday = 1,
			Wednesday = 2,
			Thursday = 3,
			Friday = 4,
			Saturday = 5,
			
		}
		static void Main(string[] args)
		{
			Console.WriteLine(CreateDayDescription(0, 0, 0));
			Console.WriteLine(CreateDayDescription(1, 1, 1));
			Console.WriteLine(CreateDayDescription(2, 2, 2));
			string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
			string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
		}

		static string CreateDayDescription(int day, int season, int year)
		{
			
			string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
			return $"{day} day of {season} in the year {year}";




		}














	}

}
