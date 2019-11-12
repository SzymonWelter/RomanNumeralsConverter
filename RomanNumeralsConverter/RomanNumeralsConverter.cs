using RomanNumeralsConverter.Mapping;
using RomanNumeralsConverter.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsConverter
{
    public class RomanNumeralsConverter : IConverter<int, string>
    {
        public string Convert(int arabicValue)
        {
            var validation = new RomanNumeralsValidator();
            var valdationResult = validation.Validate(arabicValue);

            if (!valdationResult.IsValid)
            {
                throw new ArgumentException(valdationResult.Message);
            }

            var mapService = new MapToRomanService();
            var mapResult = mapService.Map(arabicValue);

            return mapResult;
        }
    }
}
