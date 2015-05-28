using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class MatrixShuffle
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine().PadRight(n*n, ' ');
        char[,] matrix = new char[n, n];
        int row = 0;
        int col = 0;
        string direction = "right";
        int maxRotations = n * n;

        for (int i = 1; i <= maxRotations; i++)
        {
            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }

            if (direction == "up" && row < 0 || matrix[row, col] != 0)
            {
                direction = "right";
                row++;
                col++;
            }

            matrix[row, col] = input[i-1];

            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }
        string result = string.Empty;
        for (int i = 0; i < n; i++)
        {
            for (int j = i %2; j < n; j+=2)
            {
                result += matrix[i, j];
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = (i+1) % 2; j < n; j += 2)
            {
                result += matrix[i, j];
            }
        }
        
        string temp = result.ToLower();
        temp = Regex.Replace(temp, "[^a-zA-Z]", "");
        if (isPalindrome(temp))
        {
            Console.WriteLine("<div style='background-color:#4FE000'>{0}</div>", result);
        }
        else
        {
            Console.WriteLine("<div style='background-color:#E0000F'>{0}</div>", result);
        }
        
        
    }

    private static bool isPalindrome(string value)
    {
        int min = 0;
        int max = value.Length - 1;
        while (true)
        {
            if (min > max)
            {
                return true;
            }
            char a = value[min];
            char b = value[max];
            if (char.ToLower(a) != char.ToLower(b))
            {
                return false;
            }
            min++;
            max--;
        }
    }
}

