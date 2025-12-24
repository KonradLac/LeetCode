using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("PalindromeNumberTests")]

namespace PalindromeNumber
{
    internal class Solution
    {
        /// <summary>
        /// Determines whether the specified integer is a palindrome.
        /// </summary>
        /// <remarks>Negative numbers are not considered palindromes.</remarks>
        /// <param name="x">The integer value to evaluate.</param>
        /// <returns>true if the value of x reads the same backward as forward; otherwise, false.</returns>
        internal static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            int originalNumber = x;
            int revertedNumber = default;
            while (x != 0)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }
            return revertedNumber == originalNumber;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Palindrome Number");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Comparing the reversed number with the original number.");
            Console.WriteLine("Time Complexity: O(log(n))");
            Console.WriteLine("Space Complexity: O(1)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/palindrome-number/");
            Console.ResetColor();
        }
    }
}
