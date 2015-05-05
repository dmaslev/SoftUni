using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("binary = ");
        string binary = Console.ReadLine();
        long result = 0;
        int step =0;

        for (int i = binary.Length; i >0 ; i--)
        {
            result += int.Parse(binary[i-1].ToString()) * (long)Math.Pow(2, step);
            step++;
        }
        Console.WriteLine(result);
    }
}

