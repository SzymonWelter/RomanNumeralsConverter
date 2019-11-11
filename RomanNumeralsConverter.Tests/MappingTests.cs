using RomanNumeralsConverter.Mapping;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RomanNumeralsConverter.Tests
{
    public class MappingTests
    {
        private readonly IMapService<int,string> mapService;

        [Theory]
        [InlineData(1, "I")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(13, "XIII")]
        [InlineData(39, "XXXIX")]
        [InlineData(49, "XLIX")]
        [InlineData(89, "LXXXIX")]
        [InlineData(399, "CCCXCIX")]
        [InlineData(499, "CDXCIX")]
        [InlineData(894, "DCCCXCIV")]
        [InlineData(999, "MCXCIX")]
        [InlineData(3999, "MMMCMXCIX")]
        public void WhenNumberIsZero_ShouldReturnEmptyString(int arg, string expected)
        {
            var actual = mapService.Map(arg);

            Assert.Equal(expected, actual);
        }
    }
}
