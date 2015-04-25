using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char ch = char.Parse(Console.ReadLine());
        int middle = 7 / 2;
        int diff=0;
        int diffCounter = 0;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < 7; col++)
            {
                if (col>=middle - diff && col <=middle + diff)
                {
                    Console.Write(ch);
                    if (ch =='G')
                    {
                        ch = 'A';
                    }
                    else
                    {
                        ch++;
                    }
                }
                else
                {
                    Console.Write('.');

                }
            }
            if (diffCounter >= middle)
            {
                diff--;
            }
            else
            {
                diff++;
            }
            diffCounter++;
            if (diffCounter == 7)
            {
                diffCounter = 0;
                diff++;
            }
            Console.WriteLine();
        }
    }
}

