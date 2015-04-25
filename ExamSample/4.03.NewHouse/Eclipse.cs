using System;

class Eclipse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string left = new string('*', 2 * n - 2);
        string middleSpaces = new string(' ',  n + 1);
        Console.WriteLine(" " + left + middleSpaces + left + " ");
        for (int i = 0; i < n - 2 ; i++)
        {
            string space = new string(' ', n - 1);

            if (i == (n- 2) / 2)
            {
                space = new string('-', n - 1);
            }
            string lenses = new string('/', 2 * n - 2);
            Console.WriteLine("*" + lenses + "*" + space + "*" + lenses + "*");
           

        }
        Console.WriteLine(" " + left + middleSpaces + left + " ");

    }
}

