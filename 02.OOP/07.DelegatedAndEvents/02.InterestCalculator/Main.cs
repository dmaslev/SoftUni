using System;

namespace _02.InterestCalculator
{
    public delegate decimal CalculateInterest(decimal money, decimal interest, int years);


    class Program
    {

        public static decimal GetSimpleInterest(decimal money, decimal interest, int years)
        {
            decimal result = money * (1 + (interest / 100) * years);
            return result;
        }


        public const int n = 12;
        public static decimal GetCompoundInterest(decimal money, decimal interest, int years)
        {
            
            double argument = (double)(1 + ((interest / 100)) / n);
            decimal result = (decimal)((double)money * Math.Pow(argument, years * n));
            return result;

        }

        static void Main()
        {
            var acc1 = new InterestCalculator(500, 5.6m, 10, GetCompoundInterest);
            var acc2 = new InterestCalculator(2500, 7.2m, 15, GetSimpleInterest);
            Console.WriteLine("{0:F4}", acc1.GetInterestAmount);
            Console.WriteLine("{0:F4}", acc2.GetInterestAmount);
        }
    }
}
