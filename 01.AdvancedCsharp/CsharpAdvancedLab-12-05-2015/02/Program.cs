using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> result = new List<int>();
        int p = 2;
        int index = p;
        IEnumerable<int> squares = Enumerable.Range(0, n + 1).Select(x => x);
        int[] number = squares.ToArray();
        number[1] = 0;
        //result.Add(2);
        for (int i = 0; i <= Math.Sqrt(n); i++)
        {
            index = p+ i;
            while (index + p+i < number.Length)
            {
                index += p+i;
                number[index] = 0;

        
            }
        }
        Console.Write("2");

        foreach (var num in number)
        {
            if (num > 2)
            {
                Console.Write(", {0}", num);
            }
        }

    }
}

