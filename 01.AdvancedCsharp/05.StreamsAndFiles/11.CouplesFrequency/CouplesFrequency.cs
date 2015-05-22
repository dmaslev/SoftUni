using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int numberOfCouples = numbers.Length - 1;
        var coupleFequencies = new Dictionary<string, int>();

        for (int i = 1; i < numbers.Length; i++)
        {
            string currentCouple = string.Format("{0} {1}", numbers[i - 1], numbers[i]);
            if (!coupleFequencies.ContainsKey(currentCouple))
            {
                coupleFequencies.Add(currentCouple, 0);
            }
            coupleFequencies[currentCouple]++;
        }

        foreach (var couple in coupleFequencies)
        {
            double frequency = couple.Value * 100.0 / numberOfCouples;
            Console.WriteLine("{0} -> {1:f2}%", couple.Key, frequency);
        }


    }
}