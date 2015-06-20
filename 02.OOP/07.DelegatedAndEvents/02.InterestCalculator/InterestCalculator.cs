using System;

namespace _02.InterestCalculator
{
    class InterestCalculator
    {
        private decimal money;
        private decimal interest;
        private int years;

        public InterestCalculator(decimal money, decimal interest, int years, CalculateInterest calc)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.GetInterestAmount = calc(money, interest, years);
        }

        public decimal Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Amount of money cannot be negative.");
                }
                this.money = value;
            }
        }

        public decimal Interest
        {
            get { return this.interest; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest cannot be negative.");
                }
                this.interest = value;
            }
        }

        public int Years
        {
            get { return this.years; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of years cannot be negative.");
                }
                this.years = value;
            }
        }

        public CalculateInterest InterestCalcMethod { get; set; }

        public decimal GetInterestAmount { get; set; }
        //Create a class InterestCalculator that takes in its constructor money, interest, years and interest calculation delegate. Using this class calculate the interest for the following input parameters:
    }
}
