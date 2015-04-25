using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalcSomthing
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = "); 
        int k = int.Parse(Console.ReadLine());
        int result = 1;
        for (int i = k+1; i <= n; i++)
        {
            result = result * i;
        }
        Console.WriteLine("n!/k! = {0}", result);

    }
}

