using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class SimpleCalc
{
    static void Main()
    {
        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());
        int result = 0;
        if (x > 0 && y >0)
        {
            result = 1;
        }
        else if (x < 0 && y > 0)
        {
            result = 2;
        }
        else if (x < 0 && y <0)
        {
            result = 3;

        }
        else if (x >0 && y < 0)
        {
            result = 4;
        }
        else if (x ==0 && y !=0)
        {
            result =5;
        }
        else if(x!=0 && y==0)
        {
            result = 6;
        }
        Console.WriteLine(result);
    }
}

