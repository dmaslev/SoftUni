using System;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outside = (n - 1) / 2;
        int inside = 1;
        string first = new string('-', outside);
        string firstLine = first + "*" + first;
        Console.WriteLine(firstLine);


        for (int i = 0; i < n/2; i++)
        {
            --outside;           
            Console.Write(new string('-', outside));
            Console.Write("*");
            Console.Write(new string('-', inside));
            Console.Write("*");
            Console.Write(new string('-', outside));
            Console.WriteLine();
            inside += 2;

        }
         outside = 1;
         inside = n - 4;

        for (int a = 1; a < n / 2; a++)
        {
            Console.Write(new string('-', outside));
            Console.Write("*");
            Console.Write(new string('-', inside));
            Console.Write("*");
            Console.Write(new string('-', outside));
            Console.WriteLine();
            outside++;
            inside -= 2;
            

        }

        Console.WriteLine(firstLine);
    }
}

