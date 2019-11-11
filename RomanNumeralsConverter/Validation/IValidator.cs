using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsConverter.Validation
{
    internal interface IValidator
    {
        IValidationResult Validate(int arabicValue);
    }
}
