using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SpyHard
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string message = Console.ReadLine();
        string result = string.Empty;
        result = result + n + message.Length;
        int sum = 0;
        int currentValue = 0;
        for (int i = 0; i < message.Length; i++)
        {
            if (message[i] > 64 && message[i] < 91)
            {
                currentValue = message[i] - 64;
            }
            else if (message[i] > 96 && message [i] < 123)
            {
                currentValue = message[i] - 96;
            }
            else
            {
                currentValue = message[i];
            }
            sum += currentValue;
        }
        string number = string.Empty;
        int current = 0;
        while (sum > 0)
        {
            current = sum % n;
            sum /= n;
            number = "" + current + number;
        }
        Console.WriteLine(result + number);
    }
}

