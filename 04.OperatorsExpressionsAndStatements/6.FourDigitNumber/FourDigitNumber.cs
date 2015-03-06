using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FourDigitNumber
{
    static void Main()
    {
        int number = int.Parse (Console.ReadLine());
        int fourthNumber = number % 10;
        int thirdNumber = (number / 10) % 10;
        int secondNumber = (number / 100) % 10;
        int firstNUmber = (number / 1000) % 10;
        int sum = firstNUmber + secondNumber + thirdNumber + fourthNumber;
        Console.WriteLine("Sum of digits is {0}", sum);
        Console.WriteLine("{0}{1}{2}{3}", fourthNumber, thirdNumber, secondNumber, firstNUmber);
        Console.WriteLine("{0}{1}{2}{3}", fourthNumber, firstNUmber, secondNumber, thirdNumber);
        Console.WriteLine("{0}{1}{2}{3}", firstNUmber, thirdNumber, secondNumber, fourthNumber);
    }
}

