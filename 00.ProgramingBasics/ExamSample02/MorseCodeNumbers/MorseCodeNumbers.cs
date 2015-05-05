using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MorseCodeNumbers
{
    static void Main()
    {
        string n = Console.ReadLine();
        int nSum = 0;
        for (int i = 0; i < 4; i++)
        {
            nSum += int.Parse(n[i].ToString());
        }
        bool hasMorseCore = false;
        string[] morse = { "-----", ".----", "..---", "...--", "....-", "....." };

        for (int m1 = 0; m1 < 6; m1++)
        {
            for (int m2 = 0; m2 < 6; m2++)
            {
                for (int m3 = 0; m3 < 6; m3++)
                {
                    for (int m4 = 0; m4 < 6; m4++)
                    {
                        for (int m5 = 0; m5 < 6; m5++)
                        {
                            for (int m6 = 0; m6 < 6; m6++)
                            {
                                int morseProduct = 0;
                                morseProduct = m1 * m2 * m3  * m4 * m5 * m6;

                                if (nSum == morseProduct)
                                {
                                    Console.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|", morse[m1], morse[m2], morse[m3], morse[m4], morse[m5], morse[m6]);
                                    hasMorseCore = true;
                                }

                            }
                        }
                    }
                }
            }
        }
        if (!hasMorseCore)
        {
            Console.WriteLine("No");
        }
    }
}

