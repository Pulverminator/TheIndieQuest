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

        static string CreateDayDescription(int day, int season, int year)
        {
            string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
            return $"{OrdinalNumber(day)} day of {seasons[season]} in the year {year}.";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CreateDayDescription(23, 0, 2023));
            Console.WriteLine(CreateDayDescription(4, 1, 566));
            Console.WriteLine(CreateDayDescription(11, 2, 1980));
            Console.WriteLine(CreateDayDescription(18, 3, 1996));
            Console.ReadKey();
        }
    }
}
