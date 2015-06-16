using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.FractionCalculator
{
    struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }

            set
            {
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }

            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("Denominator of a rational number cannot be zero.");
                }

                if (value < 0)
                {
                    value *= -1;
                    this.Numerator *= -1;
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction fractionA, Fraction fractionB)
        {
            BigInteger resultNumerator = ((BigInteger)fractionA.Numerator * fractionB.Denominator) +
                                         ((BigInteger)fractionA.Denominator * fractionB.Numerator);

            BigInteger resultDenominator = (BigInteger)fractionA.Denominator * fractionB.Denominator;

            

            return new Fraction((long)resultNumerator, (long)resultDenominator);

        }

        public override string ToString()
        {

            return string.Format("{0}", (decimal)this.Numerator / this.Denominator);
        }
    }
}
