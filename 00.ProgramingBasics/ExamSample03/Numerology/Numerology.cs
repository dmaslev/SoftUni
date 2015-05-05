using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Numerology
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        DateTime birthDate = DateTime.Parse(inputArray[0]);
        long number = birthDate.Day * birthDate.Month * birthDate.Year;
        if (birthDate.Month % 2==1)
        {
            number *= number;
        }
        string name = inputArray[1];
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] > 47  && name[i] <58)
            {
                number += name[i] - 48;
            }
            else if (name[i] > 64 && name[i] <91)
            {
                number += 2 * (name[i] - 64);
            }
            else if (name[i] > 96 && name[i] < 123)
            {
                number += name[i] - 96;
            }
        }
        string numberAsString = number.ToString();
        while (number > 13)
        {
            numberAsString = number.ToString();
            number = 0;
            for (int i = 0; i < numberAsString.Length; i++)
            {
                number = number + int.Parse(numberAsString[i].ToString());
                    
            }

        }
        Console.WriteLine(number);
    }
}

