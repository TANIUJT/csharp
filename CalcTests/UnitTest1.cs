using System;
using Xunit;

namespace CalcTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calculator.Calc calculator = new Calculator.Calc();
            Assert.Equal(5, calculator.Sum(2, 3));
        }

        [Fact]
        public void Test2()
        {
            Calculator.Calc calculator = new Calculator.Calc();
            Assert.Equal(-10, calculator.Sum(-20, 10));
        }
    }
}
