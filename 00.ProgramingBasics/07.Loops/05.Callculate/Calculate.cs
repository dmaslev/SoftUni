using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Calculate
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = "); 
        int x = int.Parse(Console.ReadLine());
        double result = 1;
        int factoriel = 1;
        for (int i = 1; i <= n; i++)
        {
            factoriel = factoriel * i;
            result += factoriel/ Math.Pow(x, i);
            
        }
        Console.WriteLine("{0:F5}", result);
        
    }
}

