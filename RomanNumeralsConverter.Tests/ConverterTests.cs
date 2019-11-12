using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RomanNumeralsConverter.Tests
{
    public class ConverterTests
    {
        public IConverter<int, string> converter;

        public ConverterTests()
        {
            converter = new RomanNumeralsConverter();
        }

        [Fact]
        public void WhenArabicValueIsNegative_ConverterShouldThrowArgumentExceptionWithProperMessage()
        {
            var arabicValue = -420;

            string result() => converter.Convert(arabicValue);

            Assert.Throws<ArgumentException>(result);
            try
            {
                result();
            }
            catch (ArgumentException e)
            {
                Assert.Equal("Number must be positive", e.Message);
            }
            

        }

        [Fact]
        public void WhenArabicValueIsLargerThan3999_ConverterShouldThrowArgumentExceptionWithProperMessage()
        {
            var arabicValue = 42069;

            string result() => converter.Convert(arabicValue);

            Assert.Throws<ArgumentException>(result);
            try
            {
                result();
            }
            catch (ArgumentException e)
            {
                Assert.Equal("Number must be less than 4000", e.Message);
            }
        }

        [Theory]
        [InlineData(0, "")]
        [InlineData(1, "I")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(14, "XIV")]
        [InlineData(44, "XLIV")]
        [InlineData(79, "LXXIX")]
        [InlineData(99, "XCIX")]
        [InlineData(158, "CLVIII")]
        [InlineData(249, "CCXLIX")]
        [InlineData(299, "CCXCIX")]
        [InlineData(499, "CDXCIX")]
        [InlineData(2449, "MMCDXLIX")]
        [InlineData(3888, "MMMDCCCLXXXVIII")]
        public void WhenNumberIsValid_ConverterShouldReturnGoodValue(int arg, string expected)
        {
            var actual = converter.Convert(arg);

            Assert.Equal(expected, actual);
        }
    }
}
