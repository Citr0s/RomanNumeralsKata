using System.Collections.Generic;

namespace RomanNumerals
{
    public class RomanNumeralsConverter
    {
        private readonly Dictionary<int, string> _romanNumerals;

        public RomanNumeralsConverter()
        {
            _romanNumerals = new Dictionary<int, string>
            {
                { 1000, "M" },
                { 500, "D" },
                { 100, "C" },
                { 50, "L" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" }
            };
        }

        public string Convert(int number)
        {
            var response = "";

            foreach (var decimalNumber in _romanNumerals.Keys)
            {
                while (number >= decimalNumber)
                {
                    response += _romanNumerals[decimalNumber];
                    number -= decimalNumber;
                }
            }

            return response;
        }
    }
}
