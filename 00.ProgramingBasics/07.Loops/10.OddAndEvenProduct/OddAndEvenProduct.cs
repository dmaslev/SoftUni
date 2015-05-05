using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddAndEvenProduct
{
    static void Main()
    {
        string nums = Console.ReadLine();
        string[] splitNums = nums.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int productOdd = 1;
        int productEven = 1;
        for (int i = 0; i < splitNums.Length; i+=2)
        {
            productOdd *= int.Parse(splitNums[i]);
        }
        for (int i = 1; i < splitNums.Length; i+=2)
        {
            productEven *= int.Parse(splitNums[i]);
        }
        if (productEven == productOdd)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", productOdd);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", productOdd);
            Console.WriteLine("even_product = {0}", productEven);


        }
    }
}

