using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MagicString
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        char[] letters = { 's', 'n', 'k', 'p' };
        int[] weight = { 3, 4, 1, 5 };
        List<string> result = new List<string>();
        bool hasMagicString = false;
        for (int l1 = 0; l1 < 4; l1++)
        {
            for (int l2 = 0; l2 < 4; l2++)
            {
                for (int l3 = 0; l3 < 4; l3++)
                {
                    for (int l4 = 0; l4 < 4; l4++)
                    {
                        string leftWord = letters[l1].ToString() + letters[l2] + letters[l3] + letters[l4];
                        int leftWeight = weight[l1] + weight[l2] + weight[l3]+ weight[l4];
                        for (int i1 = 0; i1 < 4; i1++)
                        {
                            for (int i2 = 0; i2 < 4; i2++)
                            {
                                for (int i3 = 0; i3 < 4; i3++)
                                {
                                    for (int i4 = 0; i4 < 4; i4++)
                                    {
                                        string rightWord = letters[i1].ToString() + letters[i2] + letters[i3] + letters[i4];
                                        int rightWeight = weight[i1] + weight[i2] + weight[i3] + weight[i4];
                                        if (Math.Abs(leftWeight - rightWeight) == diff)
                                        {
                                            result.Add(leftWord+rightWord);
                                            hasMagicString = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        result.Sort();
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        if (hasMagicString == false)
        {
            Console.WriteLine("No");
        }
    }
}

