namespace RomanNumeralsConverter.Validation
{
    internal interface IValidationResult
    {
        bool IsValid { get; }
        string Message { get; }
    }
}