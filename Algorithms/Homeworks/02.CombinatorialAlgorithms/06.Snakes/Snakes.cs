namespace _06.Snakes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Snakes
    {
        private static int snakesCount = 0;
        private static List<string> allSnakes;

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[,] field = new bool[2 * n, 2 * n];
            allSnakes = new List<string>();
            List<char> directions = new List<char>();

            GenerateAllSnakes(n, directions, 'S');

            Console.WriteLine($"Snakes count = {snakesCount}");
        }

        private static void GenerateAllSnakes(int n, List<char> directions, char currentDirection)
        {
            if (directions.Count == n)
            {
                //found falid snake
            }
            else
            {
                directions.Add(currentDirection);
            }
        }
    }
}
