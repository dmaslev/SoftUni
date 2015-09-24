using System;

class CombinationsWithoutRepetition
{
    private static int n;
    private static int k;
    private static int[] nums;

    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        k = int.Parse(Console.ReadLine());
        nums = new int[k];
        NestedLoops(0, 0);
    }

    private static void NestedLoops(int currentLoop, int index)
    {
        if (currentLoop == k)
        {
            Console.WriteLine(string.Join(" ", nums));
            return;
        }

        for (int i = index + 1; i <= n; i++)
        {
            nums[currentLoop] = i;
            NestedLoops(currentLoop + 1, i);
        }
    }
}