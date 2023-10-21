using FluentAssertions;
using Xunit;

namespace 顯示類型和隱示類型的轉換
{
    public class Tests
    {
        [Fact]
        public void Divide_DivisibleIntegers_WholeNumber()
        {
            int a = 10;
            int b = 3;
            double result = a / b;
            result.Should().Be(3);
        }

        [Fact]
        public void Divide_IndivisibleIntegers_DecimalNumber()
        {
            int a = 10;
            int b = 3;
            double result = a * 1.0 / b;
            result.Should().Be(3.3333333333333335);
        }
    }
}