using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Simpleinterest s = new Simpleinterest();
            Console.WriteLine(s.GetAmount(1000,3,2));

            Console.WriteLine("Substraction: "+ Maths.Substract(12,2));
            Console.ReadLine();
        }
    }
}
