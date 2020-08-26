using System;
using System.Collections.Generic;

namespace Demo.InterestCalculator
{
    public class Simpleinterest
    {
        public double GetAmount(double principalAmount, float Year, double rate)
        {
            return Maths.Multiply(principalAmount,(Maths.Add(1, (Maths.Multiply(Year, Maths.Divide(rate, 100))))));
        }
    }
}
