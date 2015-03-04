using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HalfSum
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;
        for (int i = 0; i < num; i++)
        {
            int a = int.Parse(Console.ReadLine());
            sum1 += a;
        }
        for (int i = num; i < 2* num; i++)
        {
            int a = int.Parse(Console.ReadLine());
            sum2 += a;
        }
        if (sum1 == sum2)
        {
            Console.WriteLine("Yes, sum={0}", sum1);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sum1 - sum2));
        }
    }
}

