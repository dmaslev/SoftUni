using System;
using System.Linq;

class Numbers
{
    static void Main()
    {
        var inputParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int startNumbers = inputParams[0];
        int endNumber = inputParams[1];
        int devidor = inputParams[2];
        int remainder = inputParams[3];

        int firstNumber = 0;
        int lastNumber = 0;
        for (int i = startNumbers; i <= startNumbers + devidor; i++)
        {
            if (i % devidor == remainder)
            {
                firstNumber = i;
                break;
            }
        }

        for (int i = endNumber; i >= endNumber - devidor; i--)
        {
            if (i % devidor == remainder)
            {
                lastNumber = i;
                break;
            }
        }

        Console.WriteLine((lastNumber - firstNumber)/devidor + 1);
    }
}