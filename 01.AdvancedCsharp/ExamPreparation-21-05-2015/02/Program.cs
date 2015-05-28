using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {   
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 4; i++)
        {
            sb.AppendFormat(" {0}", Console.ReadLine());
        }

        string arrowPatten = @"(>>>----->>)|(>>----->)|(>----->)";
        Regex arrowMatcher = new Regex(arrowPatten);
        var arrows = arrowMatcher.Matches(sb.ToString());
        int largeCount = 0;
        int mediumCount = 0;
        int smallCount = 0;

        foreach (Match arrow in arrows)
        {
            if (!string.IsNullOrEmpty(arrow.Groups[1].Value))
            {
                largeCount++;
            }
            else if (!string.IsNullOrEmpty(arrow.Groups[2].Value))
            {
                mediumCount++;
            }
            else
            {
                smallCount++;
            }
        }

        string numberAsString = "" + smallCount + mediumCount + largeCount;
        string binaryNumber = Convert.ToString(Convert.ToInt32( numberAsString), 2);
        string reversed = new string(binaryNumber.Reverse().ToArray());
        string resultNumber = binaryNumber + reversed;
        int result = Convert.ToInt32(resultNumber, 2);
        Console.WriteLine(result);
    }
}

