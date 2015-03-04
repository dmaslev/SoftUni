using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter birthdate: ");
        DateTime birthdate = DateTime.Parse(Console.ReadLine());
        if (DateTime.Now.Month >= birthdate.Month && DateTime.Now.Day >=  birthdate.Day)
        {
            int age = DateTime.Now.Year - birthdate.Year;
            Console.WriteLine("You are {0} years old. After 10 years you will be {1} years old", age, age + 10);
        }
        else
        {
            int age = DateTime.Now.Year - birthdate.Year - 1;
            Console.WriteLine("You are {0} years old. After 10 years you will be {1} years old", age, age + 10);

        }
    }
}

