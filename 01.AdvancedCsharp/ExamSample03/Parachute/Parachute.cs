using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Parachute
{
    static void Main()
    {
        List<string> matrix = new List<string>();
        string line = Console.ReadLine();
        while (line != "END")
        {
            matrix.Add(line);
            line = Console.ReadLine();
        }
        int row = 0;
        int col = 0;
        for (int i = 0; i < matrix.Count; i++)
        {
            if (matrix[i].Contains('o'))
            {
                row = i;
                col = matrix[i].IndexOf('o');
                break;
            }
        }
        while (true)
        {
            MatchCollection leftMatches = Regex.Matches(matrix[row+1], "<");
            int left = leftMatches.Count;
            MatchCollection rightMatches = Regex.Matches(matrix[row+1], ">");
            int right = rightMatches.Count;
            col = col +( right - left);
            row++;

            if (ChechForHit(row, col, matrix))
            {
                
                continue;
            }
            else
            {
                Console.WriteLine("{0} {1}", row, col);
                return;

            }
        }
        
        
    }

    private static bool ChechForHit(int row, int col, List<string> matrix)
    {
        if (matrix[row][col] == '_')
        {
            Console.WriteLine("Landed on the ground like a boss!");
            return false;
        }
        else if (matrix[row][col] == '~')
        {
            Console.WriteLine("Drowned in the water like a cat!");
            return false;
        }
        else if (matrix[row][col] == '\\' || matrix[row][col] == '/' || matrix[row][col] == '|')
        {
            Console.WriteLine("Got smacked on the rock like a dog!");
            return false;
        }
        
        return true;

    }
}

