using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("LongestPalindromicSubstringTests")]

namespace LongestPalindromicSubstring
{
    internal class Solution
    {
        /// <summary>
        /// Transforms the input string into a format suitable for Manacher's algorithm by inserting separator
        /// characters.
        /// </summary>
        /// <remarks>The returned string begins with '@', ends with '$', and uses '#' as a separator
        /// between characters. This format simplifies palindrome detection by ensuring all palindromic substrings are
        /// of odd length.</remarks>
        /// <param name="s">The original string to preprocess. Can be null or empty.</param>
        /// <returns>A new string with separator characters inserted between each character and at the boundaries, or a special
        /// marker string if the input is null or empty.</returns>
        private static string ManacherPreprocessing(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return "^$";
            }
            StringBuilder result = new StringBuilder("@");
            foreach(char letter in s)
            {
                result.Append("#").Append(letter);
            }
            return result.Append("#$").ToString();
        }

        /// <summary>
        /// Calculates the length of the longest palindromic substring centered at each position in the specified
        /// string.
        /// </summary>
        /// <remarks>This method is typically used as part of palindrome detection algorithms, such as
        /// Manacher's algorithm. The returned array can be used to efficiently identify all palindromic substrings
        /// within the input string.</remarks>
        /// <param name="s">The input string for which to compute palindromic substring lengths. Cannot be null.</param>
        /// <returns>An array of integers where each element represents the length of the longest palindromic substring centered
        /// at the corresponding position in the input string.</returns>
        private static int[] MirrorCalculation(string s)
        {
            int length = s.Length;
            int[] result = new int[length];
            int center = 0;
            int right = 0;
            for (int i = 1; i < length - 1; i++)
            {
                int mirror = 2 * center - i;
                if (i < right)
                {
                    result[i] = Math.Min(right - i, result[mirror]);
                }
                else
                {
                    result[i] = 0;
                }
                // Expanding around the central element.
                while (s[i + 1 + result[i]] == s[i - 1 - result[i]])
                {
                    ++result[i];
                }
                // Updating center and right boundary if the palindrome around i expands past right.
                if (i + result[i] > right)
                {
                    center = i;
                    right = i + result[i];
                }
            }
            return result;
        }

        /// <summary>
        /// Finds the longest contiguous palindromic substring within the specified string.
        /// </summary>
        /// <param name="s">The string in which to search for the longest palindromic substring. Cannot be null.</param>
        /// <returns>A substring representing the longest contiguous palindrome found in the input string. Returns an empty
        /// string if the input is null or empty.</returns>
        internal static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;

            string transformedString = ManacherPreprocessing(s);
            int[] mirror = MirrorCalculation(transformedString);
            int maxLength = default;
            int centerIndex = default;
            for (int i = 1; i < mirror.Length - 1; i++)
            {
                if (mirror[i] > maxLength)
                {
                    maxLength = mirror[i];
                    centerIndex = i;
                }
            }
            int start = (centerIndex - maxLength) / 2;
            return s.Substring(start, maxLength);
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Longest Palindormic Substring + Appropriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Manacher's Algorithm Implementation");
            Console.WriteLine("Time complexity: O(n)");
            Console.WriteLine("Space complexity: O(n)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/longest-palindromic-substring");
            Console.ResetColor();
        }
    }
}
