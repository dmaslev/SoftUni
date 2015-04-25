using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MagicCarNumbers
{
    static void Main()
    {
        int magicWeight = int.Parse(Console.ReadLine());
        char[] letters =  {'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        int counter = 0;
        string carNumber = string.Empty;
        int currentWeight = 0;


        for (int n1 = 0; n1 <= 9; n1++)
        {
            for (int n2 = 0; n2 <= 9; n2++)
            {
                for (int n3 = 0; n3 <= 9; n3++)
                {
                    for (int n4 = 0; n4 <= 9; n4++)
                    {
                        for (int i1 = 0; i1 < letters.Length; i1++)
                        {
                            for (int i2 = 0; i2 < letters.Length; i2++)
                            {
                                if ((n1==n2 && n1 == n3 && n1 == n4) ||
                                    (n2 == n3 && n2 == n4) ||
                                    (n1 ==n2 && n1 == n3)||
                                    (n1 == n2 && n3 == n4)||
                                    (n1 == n3 && n2 ==n4)||
                                    (n1== n4 && n2==n3))
                                {
                                    currentWeight = 40 + n1 + n2 + n3 + n4 + (letters[i1] - 64) * 10 + (letters[i2] - 64) * 10;
                                }
                                if (currentWeight==magicWeight)
                                {
                                    counter++;
                                }
                                currentWeight = 0;
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(counter);
    }
}

