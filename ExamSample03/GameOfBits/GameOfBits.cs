using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GameOfBits
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        int counter = 0;
        long result = 0;
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "Game Over!")
            {
                for (int i = 0; i < 32; i++)
                {
                    long current = number & (1 << i);
                    if (current != 0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("{0} -> {1}", number, counter);
                break;
            }
            else if (command == "Odd")
            {
                for (int i = 0, position = 0; i < 32; i+=2, position++)
                {
                    long bitValue = (number >> i) & 1;
                    result = result | (bitValue << position);
                }
                number = result;
                result = 0;

            }
            else if (command == "Even")
            {
                for (int i = 1, position = 0; i < 33; i+=2, position++)
                {
                    long currentBit = (number >> i) & 1;
                    result = result | (currentBit << position);
                }
                number = result;
                result = 0;
            }
        }
    }
}

