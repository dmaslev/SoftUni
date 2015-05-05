using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger t1 = BigInteger.Parse(Console.ReadLine());
        BigInteger t2 = BigInteger.Parse(Console.ReadLine());
        BigInteger t3 = BigInteger.Parse(Console.ReadLine());
        BigInteger t4 = 0;
        int n = int.Parse(Console.ReadLine());
        if (n==1)
        {
            t4 = t1;
        }
        else if (n ==2)
        {
            t4 = t2;
        }
        else if (n == 3)
        {
            t4 = t3;
        }
        else
        {
            for (int i = 0; i < n - 3; i++)
            {
                t4 = t3 + t2 + t1;
                t1 = t2;
                t2 = t3;
                t3 = t4;


            }
        }
        Console.WriteLine(t4);
    }
}

