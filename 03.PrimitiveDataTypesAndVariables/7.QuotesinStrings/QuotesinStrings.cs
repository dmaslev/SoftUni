using System;

class QuotesinStrings
{
    static void Main()
    {
        string firstWay = "The \"use\" of quotations causes difficulties.";
        string secondWay = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine("{0}", firstWay);
        Console.WriteLine("{0}", secondWay);
    }
}

