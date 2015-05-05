using System;
using System.Linq;

class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int position = 0;
        int result = 0;
        int counter = 0;

        for (int i = 0; i < n; i++)
        {

            int number = int.Parse(Console.ReadLine());

            for (int j = 7; j >= 0; j--)
            {
                int a = 1;
                if ((position % step == 1) || (step == 1 && position > 0))
                {
                    result = result << 1;
                    int bit = number & (1 << a);
                    result = result | bit;
                    a++;
                    counter++;

                    
                }
                ++position;

                
            }

           
        }
        while (counter % 8  > 0)
        {
            result = result << 1;
            counter++;
        }
        Console.WriteLine(Convert.ToString(result, 2));
        Console.WriteLine(result);



    }
}

