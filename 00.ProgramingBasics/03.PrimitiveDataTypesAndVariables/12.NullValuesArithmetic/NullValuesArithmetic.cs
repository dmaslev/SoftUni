using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? nullInteger = null;
        double? nullDouble = null;
        Console.WriteLine("Null integer = {0} \nNull double = {1}", nullInteger, nullDouble);
        nullInteger += 2;
        nullDouble += 4.0;
        Console.WriteLine("Null number + 2 = {0}", nullInteger);
        Console.WriteLine("Null number + 4 = {0}", nullDouble);
    }
}

