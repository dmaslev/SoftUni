using System;

class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string allNumbers = "";
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
                allNumbers = allNumbers + Convert.ToString(number, 2);

        }
        int allnumber = Convert.ToInt32(allNumbers, 2);
        for (int i = 0;  step < n*8; i++)
        {
            allnumber = allnumber & (n * 8 - 1);
        }
        Console.WriteLine(Convert.ToString(allnumber, 2));

    }
}

