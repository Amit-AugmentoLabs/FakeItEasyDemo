using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.InterestCalculator
{
    public class CompoundInterest
    {
        private readonly IMaths Maths;

        public CompoundInterest(IMaths maths)
        {
            Maths = maths;
        }

        public double GetInterest(double principalAmount, int Year, double rate, int n) =>
            Maths.Multiply(principalAmount, Math.Pow(Maths.Add(1, Maths.Divide(rate, n)), Maths.Multiply(n, Year)));
    }
}
