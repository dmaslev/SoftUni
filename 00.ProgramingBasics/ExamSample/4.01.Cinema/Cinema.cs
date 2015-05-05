using System;

class Cinema
{
    static void Main()
    {
        string projectType = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
        double incomes = rows * columns;
        if (projectType == "Premiere")
        {
            Console.WriteLine("{0:0.00} leva", incomes*12.00);
        }
        else if (projectType == "Normal")
        {
            Console.WriteLine("{0:0.00} leva", incomes * 7.50);
            
        }
        else if (projectType == "Discount")
        {
            Console.WriteLine("{0:0.00} leva", incomes * 5.00);
           
        }

    }
}

