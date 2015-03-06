using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BitSifting
{
    static void Main()
    {
        ulong num = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            ulong a = ulong.Parse(Console.ReadLine());
            ulong result = num ^ a;
        }
        
    }
}

