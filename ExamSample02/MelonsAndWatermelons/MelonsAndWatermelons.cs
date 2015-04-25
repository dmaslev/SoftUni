using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MelonsAndWatermelons
{
    static void Main()
    {
        int startDay = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int watermelon = 0;
        int melons = 0;
        for (int i = startDay; i < startDay + days; i++)
        {
            int currentDay = i % 7;
            switch (currentDay)
            {
                case 1:
                    watermelon += 1;
                    break;
                case 2 :
                    melons += 2;
                    break;
                case 3:
                    watermelon += 1;
                    melons += 1;
                    break;
                case 4:
                    watermelon += 2;
                    break;
                case 5: 
                    watermelon += 2;
                    melons += 2;
                    break;
                case 6:
                    watermelon += 1;
                    melons += 2;
                    break;
                default:
                    break;
            }
        }
        if (watermelon == melons)
        {
            Console.WriteLine("Equal amount: {0}", watermelon);
        }
        else
        {
            if (watermelon > melons)
            {
                Console.WriteLine("{0} more watermelons", watermelon-melons);
            }
            else
            {
                Console.WriteLine("{0} more melons", melons - watermelon);

            }
        }
    }
}

