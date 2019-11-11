using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsConverter.Mapping
{
    internal class RomanValues : IEnumerable<KeyValuePair<int, string>>
    {
        private Dictionary<int, string> NumberRomanDictionary { get; }
        public RomanValues()
        {
            this.NumberRomanDictionary = new Dictionary<int, string>
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" },
            };
        }

        public IEnumerator<KeyValuePair<int, string>> GetEnumerator()
        {
            return NumberRomanDictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return NumberRomanDictionary.GetEnumerator();
        }
    }
}
