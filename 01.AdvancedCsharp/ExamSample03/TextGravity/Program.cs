using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int lineLingth = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        int rows = text.Length / lineLingth + (text.Length % lineLingth == 0 ? 0 : 1);
        char[,] matrix = new char[rows, lineLingth];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < lineLingth; j++)
            {
                if (i * lineLingth + j < text.Length)
                {
                    matrix[i, j] = text[i * lineLingth + j];
                }
                else
                {
                    matrix[i, j] = ' ';
                }
            }
        }
        for (int i = 0; i < rows-1; i++)
        {
            for (int row = rows - 2; row >= 0; row--)
            {
                for (int col = 0; col < lineLingth; col++)
                {
                    if (matrix[row + 1, col] == ' ')
                    {
                        matrix[row + 1, col] = matrix[row, col];
                        matrix[row, col] = ' ';
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
        Console.Write("<table>");
        for (int i = 0; i < rows; i++)
        {
            Console.Write("<tr>");
            for (int j = 0; j < lineLingth; j++)
            {
                Console.Write("<td>{0}</td>", SecurityElement.Escape(matrix[i, j].ToString()));
            }
            Console.Write("</tr>");
        }
        Console.Write("</table>");
       
    }
}
