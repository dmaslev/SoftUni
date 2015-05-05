using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CategorizeNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] asString = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<int> integer = new List<int>();
        List<double> floating = new List<double>();
        foreach (var number in asString)
        {
            double n = double.Parse(number);
            if (n % 1 == 0)
            {
                integer.Add(int.Parse(n.ToString()));
            }
            else
            {
                floating.Add(n);
            }
        }
        Console.Write("[ ");
        floating.ForEach(n => Console.Write("{0} ", n));
        Console.WriteLine("] -> min: {0:f2}, max: {1:f2}, sum: {2:f2}, avg: {3:f2}", 
            floating.Min(), floating.Max(), floating.Sum(), floating.Average());
        Console.Write("[ ");
        integer.ForEach(n => Console.Write("{0}, ", n));
        Console.WriteLine("] -> min: {0}, max: {1}, sum: {2}, avg: {3}",
            integer.Min(), integer.Max(), integer.Sum(), integer.Average());     



    }
}

