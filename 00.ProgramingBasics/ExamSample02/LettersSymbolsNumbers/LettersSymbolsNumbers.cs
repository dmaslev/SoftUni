using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LettersSymbolsNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int letter = 0;
        int number = 0;
        int symbols = 0;
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            foreach (var item in input)
            {
                if (item > 64 && item <91)
                {
                    letter += (item -64) *10;
                }
                else if (item >96 && item <123)
                {
                    letter += (item - 96) * 10;
                }
                else if ((item > 47 && item < 58))
                {
                    number += (item -48)*20;
                }
                else if (item ==32 || item ==9 || item ==10 || item ==13)
                {
                    
                }
                else
                {
                    symbols += 200;
                }
            }

        }
        Console.WriteLine(letter);
        Console.WriteLine(number);
        Console.WriteLine(symbols);
    }
}

