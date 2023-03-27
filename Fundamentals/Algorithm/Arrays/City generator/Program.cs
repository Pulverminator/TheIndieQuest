using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace City_generator
{

    internal class Program
    {
        static void GenerateRoad(bool[,] roads, int startX, int startY, int direction)
        {
            int width = roads.GetLength(0);
            int height = roads.GetLength(1);
            if (direction == 0)
            {
                for (int x = startX; x <= width - 1; x++)
                {
                    roads[x, startY] = true;
                }
            }
            if (direction == 1)
            {
                for (int y = startY; y >= 0; y--)
                {
                    roads[startX, y] = true;
                }
            }
            if (direction == 2)
            {
                for (int x = startX; x >= 0; x--)
                {
                    roads[x, startY] = true;
                }
            }
            if (direction == 3)
            {
                for (int y = startY; y <= height - 1; y++)
                {
                    roads[startX, y] = true;
                }
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            bool[,] location = new bool[35,35];
            int width = location.GetLength(0);
            int height = location.GetLength(1);

            for (int i = 0; i < 5; i++)
            {
                GenerateRoad(roads: location, startX: random.Next(width), startY: random.Next(height), direction: random.Next(4));
            }

            for (int i = height - 1; i >= 0; i--)
            {
                for (int k = 0; k < width; k++)
                {
                    Console.Write(location[k, i] ? "#" : " ");
                }
                Console.WriteLine();
            }
        }
        static void GenerateIntersection(bool[,] roads, int x, int y)
        {
            int[,,] = new int[4, 4];
        }
    }
}
