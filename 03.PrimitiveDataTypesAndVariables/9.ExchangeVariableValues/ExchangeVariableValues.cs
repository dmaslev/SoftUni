using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("A = " + a +'\n' + "B = " + b);
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("A = " + a + '\n' + "B = " + b);
    }
}

