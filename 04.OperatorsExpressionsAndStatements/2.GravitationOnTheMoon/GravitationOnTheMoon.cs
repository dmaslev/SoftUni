using System;


class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Enter your weight: ");
        float weight = float.Parse(Console.ReadLine());
        float moonWeight = weight * 17 / 100;
        Console.WriteLine("Your weight on the moon: " + moonWeight);
    }
}

