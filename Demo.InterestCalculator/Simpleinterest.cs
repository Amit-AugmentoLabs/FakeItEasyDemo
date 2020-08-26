using System;
using System.Collections.Generic;

namespace Demo.InterestCalculator
{
    public class Simpleinterest
    {
        private readonly IMaths Maths;

        public Simpleinterest(IMaths maths)
        {
            this.Maths = maths;
        }

        public double GetInterest(double principalAmount, float Year, double rate)
        {
            return Maths.Multiply(principalAmount,Year,Maths.Divide(rate,100));
        }
    }
}
