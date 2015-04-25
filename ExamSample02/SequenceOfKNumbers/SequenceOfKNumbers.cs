using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SequenceOfKNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        int k = int.Parse(Console.ReadLine());

        string[] numbers = input.Split(' ');
        int numberOfElementr = 0;
        string lastNumber = numbers[0];
        int count = 1;
        for (int i = 1  ; i < numbers.Length; i++)
        {
            if (lastNumber == numbers[i])
            {
                count++;
            }
            else
            {
                numberOfElementr = count % k;
                for (int j = 0; j < numberOfElementr; j++)
                {
                    Console.Write(lastNumber+ " ");
                }
                count = 1;
            }
            lastNumber = numbers[i];
        }
        numberOfElementr = count % k;
        for (int j = 0; j < numberOfElementr; j++)
        {
            Console.Write(lastNumber + " ");
        }
        count = 1;

        Console.WriteLine();
    }
}

