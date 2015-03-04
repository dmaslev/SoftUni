using System;


class EmployeeData
{
    static void Main()
    {
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Enter gender m/f: ");
        string Gender = Console.ReadLine();
        Console.Write("Enter Personal ID: ");
        string personalId = Console.ReadLine();
        Console.Write("Enter Employee number: ");
        string uniqueEmployeeNumber = Console.ReadLine();
        
        Console.WriteLine(
@"Name: {0} {1}
Age: {2}
Gender: {3}
Perdonal ID: {4}
Employee Unique Number: {5}", firstName, lastName, age, Gender, personalId, uniqueEmployeeNumber);

    }
}

