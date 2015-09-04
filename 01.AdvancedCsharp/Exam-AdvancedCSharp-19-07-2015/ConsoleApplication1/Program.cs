using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            int[] dimension = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[dimension[0], dimension[1]];
            int destroyedBunkers = 0;

            for (int row = 0; row < dimension[0]; row++)
            {
                string input = Console.ReadLine();
                string[] currentNumber = input.Split().ToArray();
                for (int col = 0; col < dimension[1]; col++)
                {
                    matrix[row, col] = int.Parse(currentNumber[col]);
                }
            }
            string command = Console.ReadLine();
            while (command != "cease fire!")
            {
                string[] bombParameters = command.Split();
                int bombRow = int.Parse(bombParameters[0]);
                int bombCol = int.Parse(bombParameters[1]);
                int power = (int)((char)bombParameters[2][0]);
                double power2 = Math.Ceiling(power / 2.0);

                matrix[bombRow, bombCol] -= power;
                
                for (int row = 0; row < dimension[0]; row++)
                {
                    for (int col = 0; col < dimension[1]; col++)
                    {
                        double distance = Math.Sqrt((row - bombRow) * (row - bombRow) + (col - bombCol) * (col - bombCol));
                        if (distance < 2 & distance != 0)
                        {
                            matrix[row, col] -= (int)power2;
                        }
                    }
                }

                command = Console.ReadLine();
            }
            for (int i = 0; i < dimension[0]; i++)
            {
                for (int j = 0; j < dimension[1]; j++)
                {
                    if (matrix[i, j] <= 0)
                    {
                        destroyedBunkers++;
                    }
                }
            }
            Console.WriteLine("Destroyed bunkers: {0}", destroyedBunkers);
            Console.WriteLine("Damage done: {0:p1}", ((double)destroyedBunkers / (dimension[0] * dimension[1])));



        }
    }
}
