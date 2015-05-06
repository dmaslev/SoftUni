using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GenericArraySort
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine()); 
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMax(firstNumber, secondNumber));

    }

    private static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        return secondNumber;
    }
}

