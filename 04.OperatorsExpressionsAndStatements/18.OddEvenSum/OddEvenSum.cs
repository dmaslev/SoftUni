using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;
        for (int i = 1; i <= 2*n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if (i%2==1)
            {
                sum1 += a;
            }
            else
            {
                sum2 += a;
            }
        }       
        if (sum1==sum2)
        {
            Console.WriteLine("Yes, sum={0}", sum1);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sum1-sum2));
        }
    }
}

