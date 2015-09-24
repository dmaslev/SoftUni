using System;

public class NestedLoopsRecursion
{
    private static int n;
    private static int[] loops;

    private static void Main()
    {
        n = int.Parse(Console.ReadLine());
        loops = new int[n];
        NestedLoops(0);
    }

    private static void NestedLoops(int currentLoop)
    {
        if (currentLoop == n)
        {
            PrintLoops();
            return;
        }

        for (int counter = 1; counter <= n; counter++)
        {
            loops[currentLoop] = counter;
            NestedLoops(currentLoop + 1);
        }
    }

    private static void PrintLoops()
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", loops[i]);
        }

        Console.WriteLine();
    }
}