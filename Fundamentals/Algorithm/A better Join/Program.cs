using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ConsoleApp
{
	class Program
	{

		static string JoinWithAnd(List<string> items, bool useSerialComma = true)
		{
			int count = items.Count();
			if (count == 0)
			{
				return "";
			}
			else if (items.Count == 1)
			{
				return items[0];
			}
			else if (items.Count == 2)
			{
				return $"{items[0]} and {items[1]}";
			}
			else
			{
				var itemsCopy = new List<string>(items);
				if (useSerialComma)
				{
					itemsCopy[count - 1] = " and " + itemsCopy[count - 1];
				}
				else
				{
					itemsCopy.RemoveAt(itemsCopy.Count - 1);
					itemsCopy[count - 2] = itemsCopy[count - 2] + " and " + items[count - 1];
				}
				return String.Join(",", itemsCopy);
			}				
			
		}
	
		static void Main(string[] args)
		{
			var Heroes = new List<string> { "Jazlyn", "Theron", "Dayana", "Rolando" };

			while (Heroes.Count > 0)
			{
				Console.WriteLine($"The heroes in the party are: " + JoinWithAnd(Heroes, false));
				if (Heroes.Count > 0)
				{
					Heroes.RemoveAt(0);
				}
				else
				{
					break;
				}
			}

			Console.ReadKey();
		}
	}
}



