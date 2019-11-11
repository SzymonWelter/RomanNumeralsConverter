using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsConverter.Validation
{
    internal class RomanNumeralsValidator : IValidator
    {
        public IValidationResult Validate(int arabicValue)
        {
            if (NumberIsNegative(arabicValue))
            {
                return IsNegativeResult();
            }
            else if (NumberIsTooLarge(arabicValue))
            {
                return IsTooLargeResult();
            }

            return IsValidResult();
        }

        private IValidationResult IsTooLargeResult()
        {
            var isValid = false;
            var message = "Number must be less than 4000";
            return new ValidationResult(isValid, message);
        }

        private IValidationResult IsNegativeResult()
        {
            var isValid = false;
            var message = "Number must be positive";
            return new ValidationResult(isValid, message);
        }

        private IValidationResult IsValidResult()
        {
            var isValid = true;
            var message = string.Empty;
            return new ValidationResult(isValid, message);
        }

        private bool NumberIsNegative(int arabicValue)
        {
            return arabicValue < 0;
        }

        private bool NumberIsTooLarge(int arabicValue)
        {
            return arabicValue > 3999;
        }
    }
}
