using System;

namespace Increasing_level_difficulty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 51);
            }
            
            Array.Sort(array);
            Console.WriteLine(("Number of monsters in levels: ") + (string.Join(", ", array)));
        }
    }
}
