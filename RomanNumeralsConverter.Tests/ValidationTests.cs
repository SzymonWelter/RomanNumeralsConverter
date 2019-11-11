using RomanNumeralsConverter.Validation;
using Xunit;

namespace RomanNumeralsConverter.Tests
{
    public class ValidationTests
    {

        private readonly IValidator validator;

        public ValidationTests()
        {
            this.validator = new RomanNumeralsValidator();
        }
        
        [Fact]
        public void WhenArabicValueIsNegative_ValidationShouldReturnFalseAndProperMessage()
        {
            var arabicValue = -2137;

            var result = validator.Validate(arabicValue);

            Assert.False(result.IsValid);
            Assert.Equal("Number must be positive", result.Message);

        }

        [Fact]
        public void WhenArabicValueIsLargerThan3999_ValidationShouldReturnFalseAndProperMessage()
        {
            var arabicValue = 2137420;

            var result = validator.Validate(arabicValue);

            Assert.False(result.IsValid);
            Assert.Equal("Number must be less than 4000", result.Message);
        }

        [Fact]
        public void WhenArabicValueIsValid_ValidationShouldReturnTrueAndMessageBeEmpty()
        {
            var arabicValue = 2137;

            var result = validator.Validate(arabicValue);

            Assert.True(result.IsValid);
            Assert.Equal(string.Empty, result.Message);
        }
    }
}
