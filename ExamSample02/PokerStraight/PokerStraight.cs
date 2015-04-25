using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PokerStraight
{
    static void Main()
    {
        int weight = int.Parse(Console.ReadLine());
        int counter = 0;
        int currentWeight = 0;

        for (int i = 1; i < 11; i++)
        {
            for (int suit = 1; suit < 5; suit++)
            {
                for (int suit2 = 1; suit2 < 5; suit2++)
                {
                    for (int suit3 = 1; suit3 < 5; suit3++)
                    {
                        for (int suit4 = 1; suit4 < 5; suit4++)
                        {
                            for (int suit5 = 1; suit5 < 5; suit5++)
                            {
                                currentWeight = 10 * i + suit + 20 * (i + 1) + suit2 + 30 * (i + 2) + suit3 + 40 * (i + 3) + suit4 + 50 * (i + 4) + suit5;
                                if (currentWeight == weight)
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

