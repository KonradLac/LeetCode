[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("ConversionTests")]

namespace RomanIntConversion
{
    internal class Solution
    {
        /// <summary>
        /// Converts an integer to its equivalent Roman numeral representation.
        /// </summary>
        /// <remarks>Roman numerals are represented using the standard symbols (I, V, X, L, C, D, M). Only
        /// values from 1 to 3999 are supported; values outside this range may produce incorrect results.</remarks>
        /// <param name="num">The integer value to convert. Must be in the range 1 to 3999, inclusive.</param>
        /// <returns>A string containing the Roman numeral representation of the specified integer.</returns>
        internal static string IntToRoman(int num)
        {
            string[] thousands = { "", "M", "MM", "MMM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] units = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string romanNumeral = "";
            romanNumeral += thousands[num / 1000];
            romanNumeral += hundreds[(num % 1000) / 100];
            romanNumeral += tens[(num % 100) / 10];
            romanNumeral += units[num % 10];
            return romanNumeral;
        }

        /// <summary>
        /// Converts a Roman numeral string to its equivalent integer value.
        /// </summary>
        /// <remarks>The method assumes that the input string is a well-formed Roman numeral using
        /// standard notation. Invalid or non-standard Roman numeral strings may produce incorrect results.</remarks>
        /// <param name="s">A string representing a valid Roman numeral composed of the characters 'I', 'V', 'X', 'L', 'C', 'D', and
        /// 'M'. The string must not be null or empty.</param>
        /// <returns>The integer value corresponding to the specified Roman numeral.</returns>
        internal static int RomanToInt(string s)
        {
            Dictionary<char, int> romanMap = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && romanMap[s[i]] < romanMap[s[i + 1]])
                {
                    total -= romanMap[s[i]];
                }
                else
                {
                    total += romanMap[s[i]];
                }
            }
            return total;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Roman to Integer and Integer to Roman Conversion");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Tries and errors to get familiar with C#");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/integer-to-roman/");
            Console.WriteLine(@"https://leetcode.com/problems/roman-to-integer/");
            Console.ResetColor();
        }
    }
}
