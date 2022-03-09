using StringCalculator2;
using System;
using Xunit;

namespace CalculatorTest
{
    public class StringCalculatorTests
    {
        [Fact]
        public void EmptyStringReturnsZero()
        {
            int result = Calculator.SumString("");
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("26", 26)]
        [InlineData("10", 10)]
        [InlineData("0", 0)]
        public void SingleNumberReturnsValue(string input, int expectedResult)
        {
            int result = Calculator.SumString(input);
            Assert.Equal(expectedResult, result);
        }

      
    }
}
