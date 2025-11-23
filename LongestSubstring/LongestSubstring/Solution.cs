using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("LongestSubstringTests")]

namespace LongestSubstring
{
    internal class Solution
    {
        /// <summary>
        /// Returns the length of the longest substring without repeating characters in the specified string.
        /// </summary>
        /// <param name="s">The string to search for the longest substring without repeating characters. Can be null or empty.</param>
        /// <returns>The length of the longest substring without repeating characters. Returns 0 if the input string is null or
        /// empty.</returns>
        internal static int LengthOfLongestSubstring(string s)
        {
            if (s == null || s.Length == 0)
            {
                return 0;
            }
            int first = default;
            int second = default;
            int maxLength = default;
            HashSet<char> charSet = new HashSet<char>();
            while (second < s.Length)
            {
                if (!charSet.Contains(s[second]))
                {
                    charSet.Add(s[second]);
                    second++;
                    maxLength = Math.Max(maxLength, second - first);
                }
                else
                {
                    charSet.Remove(s[first]);
                    first++;
                }
            }
            return maxLength;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Longest Substring Without Repetitions + Appropriate Tests");
            Console.ResetColor();
        }
    }
}
