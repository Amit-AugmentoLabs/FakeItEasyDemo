using System;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.InterestCalculator.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void should_return_actual_result()
        {
            double principalAmount = 1000;
            int year = 3;
            double rate = 2;
            var maths = A.Fake<IMaths>();
            A.CallTo(() => maths
                    .Multiply(A<double>._, A<double>._, A<double>._)
                )
            .Returns(60);

            A.CallTo(() => maths
                .Divide(A<double>._, A<double>._)
                )
            .Returns(0.02);

            Simpleinterest s = new Simpleinterest(maths);

            double result = s.GetInterest(principalAmount, year, rate);
            result += principalAmount;
            double ActualResult = 1060;
            Assert.AreEqual(result,ActualResult);
        }

        
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void should_throw_DivideByZeroException()
        {
            double principalAmount = 1000;
            int year = 3;
            double rate = 0;

            var maths = A.Fake<IMaths>();
            A.CallTo(() => maths
                    .Multiply(A<double>._, A<double>._, A<double>._)
                )
            .Returns(60);

            A.CallTo(() => maths
                .Divide(A<double>._, A<double>._)
                )
            .Throws(() => new DivideByZeroException());

            Simpleinterest s = new Simpleinterest(maths);

            double result = s.GetInterest(principalAmount, year, rate);
            result += principalAmount;
        }
    }
}
