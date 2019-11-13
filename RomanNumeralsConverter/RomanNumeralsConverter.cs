using RomanNumeralsConverter.Mapping;
using RomanNumeralsConverter.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsConverter
{
    public class RomanNumeralsConverter : IConverter<int, string>
    {
        private readonly IMapService<int, string> mapper;
        private readonly IValidator validation;
        public RomanNumeralsConverter()
        {
            this.validation = new RomanNumeralsValidator();
            this.mapper = new MapToRomanService();
        }

        public string Convert(int arabicValue)
        {
            var valdationResult = validation.Validate(arabicValue);

            if (!valdationResult.IsValid)
            {
                throw new ArgumentException(valdationResult.Message);
            }

            var mapResult = mapper.Map(arabicValue);

            return mapResult;
        }
    }
}
