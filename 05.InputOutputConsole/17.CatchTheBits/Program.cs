using System;
using System.Linq;

class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;
        int result = 0;
        
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            for (int j = 7; j >= 0; j--)
            {
                int a = 1;
                if ((index % step == 1) || (step == 1 && index > 0))
                {
                    result = result << 1;
                    int bit = number & (1 << a);
                    result = result | bit;
                    a++;
                    
                    
                }
                ++index;

            }


        }
        Console.WriteLine(Convert.ToString(result, 2));



    }
}

