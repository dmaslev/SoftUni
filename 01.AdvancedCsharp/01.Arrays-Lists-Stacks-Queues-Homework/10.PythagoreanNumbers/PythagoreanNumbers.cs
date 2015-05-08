using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PythagoreanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] number = new int[n];
        bool foundResult = false;
        for (int i = 0; i < n; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }
        for (int a = 0; a < number.Length; a++)
        {
            int first = number[a];

            for (int b = 0; b < number.Length; b++)
            {
                int second = number[b];
                if (first >second)
                {
                    continue;   
                }
                for (int c = 0 ; c < number.Length; c++)
                {
                    int third = number[c];
                    
                    if (first * first + second* second == third * third)
                    {
                        foundResult = true;
                        Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", first, second, third);
                    }                    
                }
            }
        }
        if (!foundResult)
        {
            Console.WriteLine("No");
        }
    }
}

