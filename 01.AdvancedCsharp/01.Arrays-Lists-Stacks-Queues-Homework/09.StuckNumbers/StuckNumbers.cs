using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StuckNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] number = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        bool foundResult = false;
        for (int a = 0; a < n; a++)
        {
            for (int b = 0; b < n; b++)
            {
                for (int c = 0; c < n; c++)
                {
                    for (int d = 0; d < n; d++)
                    {
                        int first = number[a];
                        int second = number[b];
                        int third = number[c];
                        int fourth = number[d];

                        if (first != second && first != third && first != fourth && second != third && second != fourth && third != fourth)
                        {
                            StringBuilder left = new StringBuilder();
                            StringBuilder right = new StringBuilder();
                            left.Append(first);
                            left.Append(second);
                            right.Append(third);
                            right.Append(fourth);

                            if (left.Equals(right))
                            {                                
                                Console.WriteLine("{0}|{1}=={2}|{3}", first, second, third, fourth);
                                foundResult = true;
                            }
                        }
                    }
                }
            }
        }
        if (!foundResult)
        {
            Console.WriteLine("No");
        }
    }
}
