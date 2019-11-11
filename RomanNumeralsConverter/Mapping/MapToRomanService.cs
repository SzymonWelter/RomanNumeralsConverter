using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RomanNumeralsConverter.Mapping
{
    internal class MapToRomanService : IMapService<int, string>
    {
        private readonly RomanValues romanValues;

        public MapToRomanService()
        {
            this.romanValues = new RomanValues();
        }


        public string Map(int number)
        {
            var result = new StringBuilder();

            foreach (var roman in romanValues)
            {
                while (number >= roman.Key)
                {
                    result.Append(roman.Value);
                    number -= roman.Key;
                }
            }
            return result.ToString();
        }
    }
}
