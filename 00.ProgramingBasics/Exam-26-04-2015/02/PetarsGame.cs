using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class PetarsGame
{
    static void Main()
    {
        BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger second = BigInteger.Parse(Console.ReadLine());
        string rep = Console.ReadLine();
        BigInteger sum = 0;

        for (BigInteger i = first; i < second; i++)
        {
            if (i % 5 ==0)
            {
                sum += i;
            }
            else
            {
                sum = sum + (i % 5);
            }
        }
        char digit;
        string s = sum.ToString();

        if (sum % 2 == 0)
        {
            digit = s[0];
        }
        else
        {
            digit = s[s.Length - 1];
        }
        string result = string.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == digit)
            {
                result = result + rep;
            }
            else
            {
                result = result + s[i];
            }
        }
        Console.WriteLine(result);
    }
}

