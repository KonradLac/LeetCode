using System.Text;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("ZigzagConversionTests")]

namespace ZigzagConversion
{
    internal class Solution
    {
        /// <summary>
        /// Converts the specified string to a zigzag pattern on the given number of rows and returns the result as a
        /// new string.
        /// </summary>
        /// <remarks>The method does not modify the original string.</remarks>
        /// <param name="s">The string to be converted to zigzag form.</param>
        /// <param name="numberOfRows">The number of rows to use in the zigzag pattern. Must be greater than zero.</param>
        /// <returns>A string representing the input arranged in a zigzag pattern and read row by row. If the number of rows is 1
        /// or greater than or equal to the length of the string, the original string is returned.</returns>
        internal static string ConvertZigZag(string s, int numberOfRows)
        {
            if(numberOfRows == 1 || s.Length <= numberOfRows)
            {
                return s;
            }
            StringBuilder result = new StringBuilder();
            int cycleLength = 2 * numberOfRows - 2;
            for (int i = 0; i < numberOfRows; i++)
            {
                for(int j = i; j < s.Length; j += cycleLength)
                {
                    result.Append(s[j]);
                    if (i != 0 && i != numberOfRows - 1)
                    {
                        int diagonalIndex = j + cycleLength - 2 * i;
                        if (diagonalIndex < s.Length)
                        {
                            result.Append(s[diagonalIndex]);
                        }
                    }
                }
            }
            return result.ToString();
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Zigzag Conversion + Appropriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Direct Index approach");
            Console.WriteLine("Time Complexity: O(n)");
            Console.WriteLine("Space Complexity: O(n)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("https://leetcode.com/problems/zigzag-conversion/");
            Console.ResetColor();
        }
    }
}
