using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Calc02
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int result = 1;
        int nkFactoriel = 1;
        for (int i = k + 1; i <= n; i++)
        {
            result = result * i;
        }
        //Calculating (N - K)!
        for (int i = 1; i <= n-k; i++)
        {
            nkFactoriel = nkFactoriel * i;
        }
        Console.WriteLine(result/nkFactoriel);
    }
}

