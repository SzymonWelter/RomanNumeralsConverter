using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsConverter.Mapping
{
    internal class RomanValues : IEnumerable<KeyValuePair<int, string>>
    {
        private readonly Dictionary<int, string> numberRomanDictionary;
        public RomanValues()
        {
            this.numberRomanDictionary = new Dictionary<int, string>
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
            return numberRomanDictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return numberRomanDictionary.GetEnumerator();
        }
    }
}
