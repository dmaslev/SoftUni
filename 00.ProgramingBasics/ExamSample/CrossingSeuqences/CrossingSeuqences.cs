using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CrossingSeuqences
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c =  int.Parse(Console.ReadLine());
        int startNumber =  int.Parse(Console.ReadLine());
        int step =  int.Parse(Console.ReadLine());
        int d = 0;
        int count = 0;
        List<int> tribonacci = new List<int>();
        int spiral = startNumber;
        bool hasNumber = false;
        tribonacci.Add(a);
        tribonacci.Add(b);
        tribonacci.Add(c);
        
        for (int i = 0; d < 1000000; i++)
        {
            d = a + b + c;
            tribonacci.Add(d);
            a = b;
            b = c;
            c = d;
            if (d >1000000)
            {
                break;
            }

        }
        int asdf = 0;
        while (spiral <=1000000)
        {
            
            if (tribonacci.Contains(spiral))
            {
                Console.WriteLine(spiral);
                hasNumber = true;
                break;
            }
            else
            {
                asdf++;
            }
            spiral = spiral + (count / 2 + 1) * step;
            count++;
        }
        if (hasNumber == false)
        {
            Console.WriteLine("No");
        }
    }
}

