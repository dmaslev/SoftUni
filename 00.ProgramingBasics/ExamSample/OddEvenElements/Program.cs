using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] nums = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        decimal oddSumm = 0;
        decimal evenSumm = 0;
        decimal oddMin = decimal.MaxValue;
        decimal oddMax = decimal.MinValue;
        decimal evenMin = decimal.MaxValue;
        decimal evenMax = decimal.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            decimal number = decimal.Parse(nums[i]);
            if (i%2==0)
            {
                oddSumm += number;
                oddMin = Math.Min(oddMin, number);
                oddMax = Math.Max(oddMax, number);
            }
            else
            {
                evenSumm += number;
                evenMin = Math.Min(evenMin, number);
                evenMax = Math.Max(evenMax, number);

            }
        }
        if (nums.Length>1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", (double)oddSumm, (double)oddMin, (double)oddMax, (double)evenSumm, (double)evenMin, (double)evenMax);

        }
        else if (nums.Length==1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", (double)oddSumm, (double)oddMin, (double)oddMax);

        }
        else
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");

        }
        

    }
}

