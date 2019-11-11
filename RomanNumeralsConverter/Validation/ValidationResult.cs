using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsConverter.Validation
{
    internal class ValidationResult : IValidationResult
    {
        public ValidationResult(bool isValid, string message)
        {
            this.IsValid = isValid;
            this.Message = message;
        }

        public bool IsValid { get; }

        public string Message { get; }
    }
}
