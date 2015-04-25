using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FitInTheBox
{
    static void Main()
    {
        int w1 = int.Parse(Console.ReadLine());
        int h1 = int.Parse(Console.ReadLine());
        int d1 = int.Parse(Console.ReadLine());
        int w2 = int.Parse(Console.ReadLine());
        int h2 = int.Parse(Console.ReadLine());
        int d2 = int.Parse(Console.ReadLine());
        int[] firstBox = { w1, h1, d1 };
        int[] secondBox = { w2, h2, d2 };

        Array.Sort(firstBox);
        Array.Sort(secondBox);
        if (firstBox[0] > secondBox[0] &&
            firstBox[1] > secondBox[1] &&
            firstBox[2] > secondBox[2] )
        {
            Fit(w2, h2, d2, w1, h1, d1);
            Fit(w2, h2, d2, w1, d1, h1);
            Fit(w2, h2, d2, h1, w1, d1);
            Fit(w2, h2, d2, h1, d1, w1);
            Fit(w2, h2, d2, d1, h1, w1);
            Fit(w2, h2, d2, d1, w1, h1);



        }
        else if (firstBox[0] < secondBox[0] &&
                firstBox[1] < secondBox[1] &&
                firstBox[2] < secondBox[2])
        {
            Fit(w1, h1, d1, w2, h2, d2);
            Fit(w1, h1, d1, w2, d2, h2);
            Fit(w1, h1, d1, h2, w2, d2);
            Fit(w1, h1, d1, h2, d2, w2);
            Fit(w1, h1, d1, d2, w2, h2);
            Fit(w1, h1, d1, d2, h2, w2);
        }
        else
        {
            Console.WriteLine();
        }

    }

    private static void Fit(int w2, int h2, int d2, int w1, int h1, int d1)
    {
        if (w1 > w2 && h1 > h2 && d1> d2)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w2, h2, d2, w1, h1, d1);
        }
    }
}

