using System;

namespace Demo.InterestCalculator
{
    public class Maths
    {
        public static double Multiply(double num1, double num2) => num1 * num2;
        public static double Add(double num1, double num2) => num1 + num2;
        public static double Substract(double num1, double num2) => num1 - num2;

        public static double Divide(double num1, double num2)
        {
            try
            {
            return num1 / num2;
            }
            catch(DivideByZeroException e)
            {
            throw new Exception("Divide By Zero Exception: "+ e.StackTrace, e);
            }
        }
    }
}
