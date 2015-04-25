using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max = "); 
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {

            int randomNumber = rnd.Next(min, max+1);

            Console.Write(randomNumber+ " ");
        }
        Console.WriteLine();
    }
}

