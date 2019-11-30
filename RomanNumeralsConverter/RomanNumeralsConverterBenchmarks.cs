using BenchmarkDotNet.Attributes;
using RomanNumeralsConverter.Mapping;
using RomanNumeralsConverter.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsConverter
{
    [MemoryDiagnoser]
    public class RomanNumeralsConverterBenchmarks
    {
        private static readonly RomanNumeralsConverter _converter = new RomanNumeralsConverter();
        private static readonly RomanNumeralsValidator _validator = new RomanNumeralsValidator();
        private static readonly MapToRomanService _mapper = new MapToRomanService();
        public int arabicValue = 3888;

        [Benchmark]
        public void Convert()
        {
            _converter.Convert(arabicValue);
        }
        [Benchmark]
        public void Validate()
        {
            _validator.Validate(arabicValue);
        }
        [Benchmark]
        public void IsTooLargeResult()
        {
            _validator.IsTooLargeResult();
        }
        [Benchmark]
        public void IsNegativeResult()
        {
            _validator.IsNegativeResult();
        }
        [Benchmark]
        public void IsValidResult()
        {
            _validator.IsValidResult();
        }
        [Benchmark]
        public void NumberIsNegative()
        {
            _validator.NumberIsNegative(arabicValue);
        }
        [Benchmark]
        public void NumberIsTooLarge()
        {
            _validator.NumberIsTooLarge(arabicValue);
        }
        [Benchmark]
        public void Map()
        {
            _mapper.Map(arabicValue);
        }

    }
}
