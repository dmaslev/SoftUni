using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Beers
{
    static void Main()
    {
        int allBeers = 0;
        int stack = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }
            else
            {
                string[] split = input.Split(' ');
                int number = int.Parse(split[0].ToString());
                if (split[1] == "beers")
                {
                    allBeers += number;
                }
                else
                {
                    allBeers += number * 20;
                }
            }

            
        }
        Console.Write(allBeers/20 + " stacks");
        Console.WriteLine(" + {0} beers", allBeers%20);
    }
}

