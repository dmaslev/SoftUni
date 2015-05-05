using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrimeCheker
{
    static void Main()
    {
        Console.Write("n = ");
        long n = long.Parse(Console.ReadLine());
        
        bool result = IsPrime(n);
        Console.WriteLine(result);
    }

    private static bool IsPrime(long n)
    {
        bool isPrime = true;
        if (n < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        return isPrime;
    }
}

