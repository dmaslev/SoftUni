using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        string copyRight = "\u00A9";
        int row = int.Parse(Console.ReadLine());
        Console.WriteLine(copyRight.PadLeft(row));
        if (row > 1)
        {
            for (int i = 2; i < row  ; i++)
            {
                string leftSpaces = new string(' ', row - i);
                string middleSpaces = new string(' ', 2 * i - 3);
                Console.WriteLine(leftSpaces + copyRight + middleSpaces + copyRight);
            }
            for (int i = 0; i < row; i++)
            {
                Console.Write(copyRight + ' ');
            }
            Console.WriteLine();

        }

    }
}