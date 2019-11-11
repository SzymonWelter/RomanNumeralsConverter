using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsConverter.Validation
{
    internal class RomanNumeralsValidator : IValidator
    {
        public IValidationResult Validate(int arabicValue)
        {
            var message = string.Empty;
            var isValid = true;
            if( arabicValue < 0)
            {
                isValid = false;
                message = "Number must be positive";
            }
            else if(arabicValue > 3999)
            {
                isValid = false;
                message = "Number must be less than 4000";
            }
            return new ValidationResult(isValid, message);
        }
    }
}
