using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int top = 1;
        int left = n / 2;
        for (int i = 0; i < n/2 +1 ; i++)
        {
            string left2 = new string('-', left);
            string middle = new string('*', top);
            Console.Write(left2 + middle + left2);
            Console.WriteLine();
            --left;
            top += 2;
        }
        for (int i = 0; i < n; i++)
        {
            string wall = ("|");
            Console.WriteLine(wall + new string('*', n - 2)+ wall);
        }
    }
}

