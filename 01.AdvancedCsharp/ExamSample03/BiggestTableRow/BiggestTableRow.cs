using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BiggestTableRow
{
    class BiggestTableRow
    {
        static void Main()
        {
            string firstLine = Console.ReadLine();
            string bullshit = Console.ReadLine();
            string line = Console.ReadLine();
            double maxSum = double.MinValue;
            string maxLine = string.Empty;
            List<string> result = new List<string>();
            while (line != "</table>")
            {
                double currenSum = 0;

                string pattern = @"<td>(-?\d[.\d]*)<\/td>";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(line);
                foreach (Match match in matches)
                {
                    currenSum += double.Parse(match.Groups[1].ToString());
                }
                if (currenSum > maxSum)
                {
                    maxSum = currenSum;
                    maxLine = line;

                }
                line = Console.ReadLine();
            }
            
            string p = @"<td>(-?\d[.\d]*)<\/td>";
            Regex reg = new Regex(p);
            MatchCollection m = reg.Matches(maxLine);
            foreach (Match match in m)
            {
                result.Add(match.Groups[1].ToString());
            }
            if (result.Count ==0)
            {
                Console.WriteLine("no data");
                return;
            }
            Console.Write("{0} = ", maxSum);
            Console.WriteLine(string.Join(" + ", result));

        }
            
    }
}
