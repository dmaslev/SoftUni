using System;

class StringsandObjects
{
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World";
        object both = firstWord + " " + secondWord;
        Console.WriteLine("{0}", both);
        string bothWors = (string)both;
        Console.WriteLine("{0}", bothWors);

    }
}

