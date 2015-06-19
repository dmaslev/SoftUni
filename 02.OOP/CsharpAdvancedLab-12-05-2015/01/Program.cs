using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static List<int> primeNumber = new List<int>();

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> result = new List<int>();
        int nPrint = n;

        while (n != 1)
        {
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    result.Add(i);
                    n = n / i;
                }
            }
            
        }
        Console.Write("{0} = ", nPrint);
        Console.WriteLine(string.Join(" * ", result));
    }

    
}

