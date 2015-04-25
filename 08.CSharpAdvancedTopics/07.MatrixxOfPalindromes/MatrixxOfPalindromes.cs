using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixxOfPalindromes
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] matrix = input.Split();
        int rows = int.Parse(matrix[0]);
        int cols = int.Parse(matrix[1]);
        char symbol = 'a';

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0}{1}{0} ", (char)(symbol +i), (char)(symbol +j + i));   
            }
            Console.WriteLine();
        }
    }
}

