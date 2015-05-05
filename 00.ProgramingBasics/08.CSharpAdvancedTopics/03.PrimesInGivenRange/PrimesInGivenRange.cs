using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrimesInGivenRange
{
    static void Main()
    {
        Console.Write("Start number = ");
        long startNum = long.Parse(Console.ReadLine());
        Console.Write("End number = ");
        long endNum = long.Parse(Console.ReadLine());
        if (startNum > endNum)
        {
            Console.WriteLine("(empty list)");
        }
        else
        {
            var primeNumbers = FindPrimesInRange(startNum, endNum);
            PrintPrimeInGivenRange(primeNumbers);
        }
        
        
    }

    private static void PrintPrimeInGivenRange(List<long> primeNumbers)
    {
        foreach (var number in primeNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
    static List<long> FindPrimesInRange(long start, long end)
    {
        List<long> primes = new List<long>();
        for (long i = start; i <= end; i++)
        {
            bool isPrime = true;

            if (i < 2)
            {
                isPrime = false;
            }
            for (long a = 2; a <= Math.Sqrt(i); a++)
            {
                
                if (i % a ==0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                primes.Add(i);
            }
        }
        return primes;
    }
}

