using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MatrixOfNumbers
{
    static void Main()
    {
        int n;
        int number = 0;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n > 100)
        {
            Console.WriteLine("Invalid input!!!");
        }
        for (int row = 0; row < n; row++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write(j + number + " ");
            }
            number++;

            Console.WriteLine();
        }

    }
}

