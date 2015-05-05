using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StudentCables
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int finalLengh = 0;
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            int cableLengh = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();
            if (measure == "meters")
            {
                cableLengh = cableLengh * 100;
            }
            if (cableLengh<20)
            {
                continue;
            }
            else
            {
                finalLengh += cableLengh;
                counter++;
            }
        }
        finalLengh = finalLengh - (counter-1) * 3;
        Console.WriteLine(finalLengh/504);
        Console.WriteLine(finalLengh% 504);

    }
}

