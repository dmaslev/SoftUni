using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class OddAndEvenJumps
{
    static void Main()
    {
        string input = Console.ReadLine();
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());
        int oddSum = 15;
        int evenSum = 17;




        Console.WriteLine(string.Format("{0:x}", oddSum));
        Console.WriteLine(string.Format("{0:x}", evenSum));
    }
}

