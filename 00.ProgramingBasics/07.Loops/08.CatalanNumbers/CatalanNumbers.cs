using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class CatalanNumbers
{
    static void Main()
    {
        BigInteger n;
        BigInteger doubleFactoriel = 1;
        BigInteger nFactoriel = 1;
        while (!BigInteger.TryParse(Console.ReadLine(), out n) || n <= 0 || n > 100)
        {
            Console.WriteLine("Invalid input");
        }
        for (int i = 1; i <= 2* n; i++)
        {
            doubleFactoriel *= i;   
        }
        for (int i = 1; i <= n; i++)
        {
            nFactoriel *= i;
        }
        Console.WriteLine(doubleFactoriel/ (nFactoriel *(n +1)* nFactoriel));
    }
}

